using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace PublixRDPEnhancer
{
    public partial class mCanvas : Form
    {
        #region Retrieve Known Folder Logic
        public enum KnownFolder
        {
            Downloads
        }

        public static class KnownFolders
        {
            private static readonly Dictionary<KnownFolder, Guid> _guids = new()
            {
                [KnownFolder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B")
            };

            public static string GetPath(KnownFolder knownFolder)
            {
                return SHGetKnownFolderPath(_guids[knownFolder], 0);
            }

            [DllImport("shell32",
                CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
            private static extern string SHGetKnownFolderPath(
                [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
                nint hToken = 0);
        }
        #endregion

        string downloadPath = KnownFolders.GetPath(KnownFolder.Downloads);
        string[] rdpFiles;
        bool connected;

        int ver, rev;

        // AutoClick vars
        int acInterval, acIntervalDis;
        long acElapsed;
        bool acEnabled;
        Random r = new Random();
        Stopwatch sw = new Stopwatch();

        // Mouse Click DLL imports

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public mCanvas()
        {
            InitializeComponent();

            ver = 1;
            rev = 6;
            versionDisplay.Text = "Version: " + ver + "." + rev;

            // title logic
            publixTitle.Text = "";
            AppendText(publixTitle, "Publix ", System.Drawing.Color.Green);
            AppendText(publixTitle, "RDP ", System.Drawing.Color.Blue);
            AppendText(publixTitle, "Enhancer", System.Drawing.Color.Black);
            publixTitle.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void doEnhancedConnect()
        {

            // Will take all .RDP files in your Downloads directory and delete all of them except the latest one (if only one exists, nothing happens)
            DirectoryInfo downloadsDirectory = new DirectoryInfo(downloadPath);
            var query = downloadsDirectory.GetFiles("*.rdp", SearchOption.TopDirectoryOnly);
            foreach (var file in query.OrderByDescending(file => file.CreationTime).Skip(1))
            {
                file.Delete();
            }

            rdpFiles = Directory.GetFiles(downloadPath, "*.rdp", SearchOption.TopDirectoryOnly);


            // Check to ensure the only RDP file left is the latest one downloaded from Publix RDP
            if (rdpFiles.Length == 1)
            {
                // Read contents of RDP file
                StreamReader read = new StreamReader(rdpFiles[0]);
                string currLine = "";
                string rdpContents = "";
                while ((currLine = read.ReadLine()) != null)
                {
                    // We can set User-desired Settings here so we can save on additional logic when writing back to the file

                    // Remote Mic Device Option
                    if (currLine.Contains("audiocapturemode:i:"))
                    {
                        if (enableMic.Checked)
                            currLine = currLine.Substring(0, currLine.Length - 1) + "1";
                        else
                            currLine = currLine.Substring(0, currLine.Length - 1) + "0";

                    }

                    // Dual Monitor Option
                    if (currLine.Contains("use multimon:i:"))
                    {
                        if (enableMultiMonitor.Checked)
                            currLine = currLine.Substring(0, currLine.Length - 1) + "1";
                        else
                            currLine = currLine.Substring(0, currLine.Length - 1) + "0";
                    }
                        

                    rdpContents += currLine + "\n";
                }
                read.Close();

                /* Check if remote web cam option is enabled; if so, add the setting to the end of the rdpContents ; as it will not exist in a fresh .rdp file from Citrix
                   There is no need to make a check for if the option isnt enabled since the .rdp file is stale after establishing a connection at least once with it */
                if (enableCam.Checked)
                {
                    rdpContents += "camerastoredirect:s:*" + "\n";
                }

                // Trim rdpContents before writing it to the .rdp file
                rdpContents = rdpContents.Trim();

                // Write updated contents to RDP file
                StreamWriter write = new StreamWriter(rdpFiles[0]);
                write.Write(rdpContents);
                write.Close();

                // Open and Establish RDP session

                Process.Start(@"C:\Windows\System32\mstsc.exe", rdpFiles[0]);
                
            }
            else
            {
                MessageBox.Show("Old RDP File Deletion Did Not Run, No RDP File Found or Another Error Occurred! Delete All RDP files in your Download directory" +
                    " and try again.", "Error");
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!connected)
                doEnhancedConnect();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.aboutInfo, "About The Publix RDP Enhancer");
        }

        private void checkRDP_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("mstsc");

            // the RDP process is not opened / running
            if (processes.Length == 0)
            {
                connected = false;
                connectButton.Enabled = true;
                this.connectButton.BackgroundImage = global::PublixRDPEnhancer.Properties.Resources.preconnectButton;
                estSessionDis.Text = Properties.Resources.notConnected;
                estSessionDis.ForeColor = System.Drawing.Color.Black;
            }
            else // process is running
            {
                connected = true;
                connectButton.Enabled = false;
                this.connectButton.BackgroundImage = global::PublixRDPEnhancer.Properties.Resources.connectButton;
                estSessionDis.Text = Properties.Resources.sessionEst;
                estSessionDis.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void killProcess_Click(object sender, EventArgs e)
        {
            foreach (var p in Process.GetProcessesByName("mstsc"))
            {
                p.Kill();
            }
        }

        private void helpAutoClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.autoClickHelp, "Auto Click Help");
        }



        private void ACButton_Click(object sender, EventArgs e)
        {
            if (!acEnabled)
            {
                acEnabled = true;
                ACButton.Text = Properties.Resources.stopAC;
                clickTimerDis.Visible = true;

                // set initial interval
                acInterval = r.Next(10000, 60001); // between 10000 ms to 60001 (exclusive so 60000) ms ; or 10 to 60 seconds
                acIntervalDis = acInterval;
                autoClickTimer.Interval = acInterval;

                // start the timers
                autoClickTDisplay.Start();
                autoClickTimer.Start();
                sw.Start();

            }
            else if (acEnabled)
            {
                acEnabled = false;
                ACButton.Text = Properties.Resources.startAC;
                clickTimerDis.Visible = false;

                // stop the timers
                autoClickTDisplay.Stop();
                autoClickTimer.Stop();
                sw.Stop();
                sw.Reset();

            }
        }

        private void autoClickTimer_Tick(object sender, EventArgs e)
        {
            // replicate click
            LeftMouseClick(Cursor.Position.X, Cursor.Position.Y);

            // new interval and restart stop watch
            acInterval = r.Next(10000, 60001); // between 10000 ms to 60001 (exclusive so 60000) ms ; or 10 to 60 seconds
            autoClickTimer.Interval = acInterval;
            sw.Stop();
            sw.Restart();
            sw.Start();
            
        }

        private void autoClickTDisplay_Tick(object sender, EventArgs e)
        {
            acElapsed = ((acInterval / 1000) - (sw.ElapsedMilliseconds / 1000));

            if (acElapsed != -1) // prevent display timer from going to negative territory
                clickTimerDis.Text = "Next Click In:\n" + ((acInterval/1000) - (sw.ElapsedMilliseconds/1000)) + " seconds";
        }

        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        // simulates mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)xpos, (uint)ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)xpos, (uint)ypos, 0, 0);
        }
    }
}