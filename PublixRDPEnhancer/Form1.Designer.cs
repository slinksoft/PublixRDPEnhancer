namespace PublixRDPEnhancer
{
    partial class mCanvas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mCanvas));
            this.enableMic = new System.Windows.Forms.CheckBox();
            this.enableMultiMonitor = new System.Windows.Forms.CheckBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.publixTitle = new System.Windows.Forms.RichTextBox();
            this.warning = new System.Windows.Forms.Label();
            this.versionDisplay = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRDP = new System.Windows.Forms.Timer(this.components);
            this.estSessionDis = new System.Windows.Forms.Label();
            this.statusLabelDis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableMic
            // 
            this.enableMic.AutoSize = true;
            this.enableMic.Checked = true;
            this.enableMic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableMic.Location = new System.Drawing.Point(62, 74);
            this.enableMic.Name = "enableMic";
            this.enableMic.Size = new System.Drawing.Size(166, 19);
            this.enableMic.TabIndex = 0;
            this.enableMic.Text = "Enable Remote Mic Device";
            this.enableMic.UseVisualStyleBackColor = true;
            // 
            // enableMultiMonitor
            // 
            this.enableMultiMonitor.AutoSize = true;
            this.enableMultiMonitor.Checked = true;
            this.enableMultiMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableMultiMonitor.Location = new System.Drawing.Point(76, 99);
            this.enableMultiMonitor.Name = "enableMultiMonitor";
            this.enableMultiMonitor.Size = new System.Drawing.Size(134, 19);
            this.enableMultiMonitor.TabIndex = 1;
            this.enableMultiMonitor.Text = "Enable Dual Monitor";
            this.enableMultiMonitor.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.BackgroundImage = global::PublixRDPEnhancer.Properties.Resources.preconnectButton;
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectButton.Location = new System.Drawing.Point(93, 120);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(101, 89);
            this.connectButton.TabIndex = 2;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // publixTitle
            // 
            this.publixTitle.BackColor = System.Drawing.SystemColors.Control;
            this.publixTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publixTitle.Enabled = false;
            this.publixTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.publixTitle.ForeColor = System.Drawing.Color.Green;
            this.publixTitle.Location = new System.Drawing.Point(0, 13);
            this.publixTitle.Name = "publixTitle";
            this.publixTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.publixTitle.Size = new System.Drawing.Size(289, 22);
            this.publixTitle.TabIndex = 5;
            this.publixTitle.Text = "Publix RDP Enhancer";
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warning.Location = new System.Drawing.Point(19, 252);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(251, 191);
            this.warning.TabIndex = 6;
            this.warning.Text = resources.GetString("warning.Text");
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionDisplay
            // 
            this.versionDisplay.AutoSize = true;
            this.versionDisplay.Location = new System.Drawing.Point(212, 471);
            this.versionDisplay.Name = "versionDisplay";
            this.versionDisplay.Size = new System.Drawing.Size(66, 15);
            this.versionDisplay.TabIndex = 7;
            this.versionDisplay.Text = "Version: 0.0";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(9, 446);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(87, 42);
            this.aboutButton.TabIndex = 8;
            this.aboutButton.Text = "What Does This Do?";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 67);
            this.label2.TabIndex = 9;
            this.label2.Text = "By: SlinkSoft - A Publix Software Engineer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkRDP
            // 
            this.checkRDP.Enabled = true;
            this.checkRDP.Interval = 500;
            this.checkRDP.Tick += new System.EventHandler(this.checkRDP_Tick);
            // 
            // estSessionDis
            // 
            this.estSessionDis.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.estSessionDis.ForeColor = System.Drawing.Color.Black;
            this.estSessionDis.Location = new System.Drawing.Point(20, 233);
            this.estSessionDis.Name = "estSessionDis";
            this.estSessionDis.Size = new System.Drawing.Size(248, 19);
            this.estSessionDis.TabIndex = 10;
            this.estSessionDis.Text = "N/A";
            this.estSessionDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabelDis
            // 
            this.statusLabelDis.AutoSize = true;
            this.statusLabelDis.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.statusLabelDis.ForeColor = System.Drawing.Color.Black;
            this.statusLabelDis.Location = new System.Drawing.Point(119, 212);
            this.statusLabelDis.Name = "statusLabelDis";
            this.statusLabelDis.Size = new System.Drawing.Size(49, 19);
            this.statusLabelDis.TabIndex = 11;
            this.statusLabelDis.Text = "Status";
            this.statusLabelDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 492);
            this.Controls.Add(this.statusLabelDis);
            this.Controls.Add(this.estSessionDis);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.versionDisplay);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.publixTitle);
            this.Controls.Add(this.enableMultiMonitor);
            this.Controls.Add(this.enableMic);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(303, 531);
            this.MinimumSize = new System.Drawing.Size(303, 531);
            this.Name = "mCanvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publix RDP Enhancer - By SlinkSoft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox enableMic;
        private CheckBox enableMultiMonitor;
        private Button connectButton;
        private RichTextBox publixTitle;
        private Label warning;
        private Label versionDisplay;
        private Button aboutButton;
        private Label label2;
        private System.Windows.Forms.Timer checkRDP;
        private Label estSessionDis;
        private Label statusLabelDis;
    }
}