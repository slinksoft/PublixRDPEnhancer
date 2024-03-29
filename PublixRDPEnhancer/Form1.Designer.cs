﻿namespace PublixRDPEnhancer
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
            this.killProcess = new System.Windows.Forms.Button();
            this.ACButton = new System.Windows.Forms.Button();
            this.helpAutoClick = new System.Windows.Forms.Button();
            this.toolTipper = new System.Windows.Forms.ToolTip(this.components);
            this.enableCam = new System.Windows.Forms.CheckBox();
            this.clickTimerDis = new System.Windows.Forms.Label();
            this.autoClickTimer = new System.Windows.Forms.Timer(this.components);
            this.autoClickTDisplay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enableMic
            // 
            this.enableMic.AutoSize = true;
            this.enableMic.Checked = true;
            this.enableMic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableMic.Location = new System.Drawing.Point(44, 78);
            this.enableMic.Name = "enableMic";
            this.enableMic.Size = new System.Drawing.Size(166, 19);
            this.enableMic.TabIndex = 0;
            this.enableMic.Text = "Enable Remote Mic Device";
            this.toolTipper.SetToolTip(this.enableMic, "Enable/Disable Mic For Your Session");
            this.enableMic.UseVisualStyleBackColor = true;
            // 
            // enableMultiMonitor
            // 
            this.enableMultiMonitor.AutoSize = true;
            this.enableMultiMonitor.Checked = true;
            this.enableMultiMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableMultiMonitor.Location = new System.Drawing.Point(238, 78);
            this.enableMultiMonitor.Name = "enableMultiMonitor";
            this.enableMultiMonitor.Size = new System.Drawing.Size(134, 19);
            this.enableMultiMonitor.TabIndex = 1;
            this.enableMultiMonitor.Text = "Enable Dual Monitor";
            this.toolTipper.SetToolTip(this.enableMultiMonitor, "Enable/Disable Dual Monitors For Your Session");
            this.enableMultiMonitor.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.BackgroundImage = global::PublixRDPEnhancer.Properties.Resources.preconnectButton;
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectButton.Location = new System.Drawing.Point(159, 120);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(101, 89);
            this.connectButton.TabIndex = 2;
            this.toolTipper.SetToolTip(this.connectButton, "Connect!");
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
            this.publixTitle.Location = new System.Drawing.Point(66, 13);
            this.publixTitle.Name = "publixTitle";
            this.publixTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.publixTitle.Size = new System.Drawing.Size(289, 22);
            this.publixTitle.TabIndex = 5;
            this.publixTitle.Text = "Publix RDP Enhancer";
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warning.Location = new System.Drawing.Point(39, 307);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(339, 168);
            this.warning.TabIndex = 6;
            this.warning.Text = resources.GetString("warning.Text");
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionDisplay
            // 
            this.versionDisplay.AutoSize = true;
            this.versionDisplay.Location = new System.Drawing.Point(341, 587);
            this.versionDisplay.Name = "versionDisplay";
            this.versionDisplay.Size = new System.Drawing.Size(66, 15);
            this.versionDisplay.TabIndex = 7;
            this.versionDisplay.Text = "Version: 0.0";
            this.toolTipper.SetToolTip(this.versionDisplay, "The Current Version Number Of This Program");
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(165, 265);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(87, 42);
            this.aboutButton.TabIndex = 8;
            this.aboutButton.Text = "What Does This Do?";
            this.toolTipper.SetToolTip(this.aboutButton, "Help");
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 67);
            this.label2.TabIndex = 9;
            this.label2.Text = "By: SlinkSoft - A Publix Software Engineer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipper.SetToolTip(this.label2, "Developed By SlinkSoft\r\nDeveloper For Store 619");
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
            this.estSessionDis.Location = new System.Drawing.Point(86, 233);
            this.estSessionDis.Name = "estSessionDis";
            this.estSessionDis.Size = new System.Drawing.Size(248, 19);
            this.estSessionDis.TabIndex = 10;
            this.estSessionDis.Text = "N/A";
            this.estSessionDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipper.SetToolTip(this.estSessionDis, "Connection Status");
            // 
            // statusLabelDis
            // 
            this.statusLabelDis.AutoSize = true;
            this.statusLabelDis.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.statusLabelDis.ForeColor = System.Drawing.Color.Black;
            this.statusLabelDis.Location = new System.Drawing.Point(185, 212);
            this.statusLabelDis.Name = "statusLabelDis";
            this.statusLabelDis.Size = new System.Drawing.Size(49, 19);
            this.statusLabelDis.TabIndex = 11;
            this.statusLabelDis.Text = "Status";
            this.statusLabelDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // killProcess
            // 
            this.killProcess.Location = new System.Drawing.Point(124, 477);
            this.killProcess.Name = "killProcess";
            this.killProcess.Size = new System.Drawing.Size(172, 42);
            this.killProcess.TabIndex = 12;
            this.killProcess.Text = "Kill Hanging/Unresponsive RDP Processes";
            this.toolTipper.SetToolTip(this.killProcess, "Kill Unresponsive RDP Processes");
            this.killProcess.UseVisualStyleBackColor = true;
            this.killProcess.Click += new System.EventHandler(this.killProcess_Click);
            // 
            // ACButton
            // 
            this.ACButton.Location = new System.Drawing.Point(124, 533);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(172, 42);
            this.ACButton.TabIndex = 13;
            this.ACButton.Text = "Start Auto Click To Keep Session Alive";
            this.toolTipper.SetToolTip(this.ACButton, "Auto Click Function");
            this.ACButton.UseVisualStyleBackColor = true;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // helpAutoClick
            // 
            this.helpAutoClick.Location = new System.Drawing.Point(302, 533);
            this.helpAutoClick.Name = "helpAutoClick";
            this.helpAutoClick.Size = new System.Drawing.Size(26, 22);
            this.helpAutoClick.TabIndex = 14;
            this.helpAutoClick.Text = "?";
            this.toolTipper.SetToolTip(this.helpAutoClick, "Auto Click Help and Explanation");
            this.helpAutoClick.UseVisualStyleBackColor = true;
            this.helpAutoClick.Click += new System.EventHandler(this.helpAutoClick_Click);
            // 
            // enableCam
            // 
            this.enableCam.AutoSize = true;
            this.enableCam.Location = new System.Drawing.Point(132, 98);
            this.enableCam.Name = "enableCam";
            this.enableCam.Size = new System.Drawing.Size(160, 19);
            this.enableCam.TabIndex = 16;
            this.enableCam.Text = "Enable Remote Web Cam";
            this.toolTipper.SetToolTip(this.enableCam, "Enable/Disable Web Cam For Your Session");
            this.enableCam.UseVisualStyleBackColor = true;
            // 
            // clickTimerDis
            // 
            this.clickTimerDis.Location = new System.Drawing.Point(18, 533);
            this.clickTimerDis.Name = "clickTimerDis";
            this.clickTimerDis.Size = new System.Drawing.Size(100, 42);
            this.clickTimerDis.TabIndex = 15;
            this.clickTimerDis.Text = "Next Click In:\r\n0 seconds";
            this.clickTimerDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickTimerDis.Visible = false;
            // 
            // autoClickTimer
            // 
            this.autoClickTimer.Interval = 1000;
            this.autoClickTimer.Tick += new System.EventHandler(this.autoClickTimer_Tick);
            // 
            // autoClickTDisplay
            // 
            this.autoClickTDisplay.Interval = 1000;
            this.autoClickTDisplay.Tick += new System.EventHandler(this.autoClickTDisplay_Tick);
            // 
            // mCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 614);
            this.Controls.Add(this.enableCam);
            this.Controls.Add(this.clickTimerDis);
            this.Controls.Add(this.helpAutoClick);
            this.Controls.Add(this.ACButton);
            this.Controls.Add(this.killProcess);
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
            this.MaximumSize = new System.Drawing.Size(438, 653);
            this.MinimumSize = new System.Drawing.Size(438, 653);
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
        private Button killProcess;
        private Button ACButton;
        private Button helpAutoClick;
        private ToolTip toolTipper;
        private Label clickTimerDis;
        private System.Windows.Forms.Timer autoClickTimer;
        private System.Windows.Forms.Timer autoClickTDisplay;
        private CheckBox enableCam;
    }
}