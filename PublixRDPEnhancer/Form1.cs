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

        public mCanvas()
        {
            InitializeComponent();

            ver = 1;
            rev = 1;
            versionDisplay.Text = "Version: " + ver + "." + rev;

            // title logic
            publixTitle.Text = "";
            AppendText(publixTitle, "Publix ", System.Drawing.Color.Green);
            AppendText(publixTitle, "RDP ", System.Drawing.Color.Blue);
            AppendText(publixTitle, "Enhancer", System.Drawing.Color.Black);

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

        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}