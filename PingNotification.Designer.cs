namespace PingTimeoutNotifications
{
    partial class PingNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingNotification));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnAddIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIPs = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numudInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.lblStopped = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(134, 12);
            this.txtIP.MaxLength = 20;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(161, 20);
            this.txtIP.TabIndex = 0;
            // 
            // btnAddIP
            // 
            this.btnAddIP.Location = new System.Drawing.Point(220, 38);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(75, 23);
            this.btnAddIP.TabIndex = 1;
            this.btnAddIP.Text = "Add";
            this.btnAddIP.UseVisualStyleBackColor = true;
            this.btnAddIP.Click += new System.EventHandler(this.btnAddIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP to Add";
            // 
            // lstIPs
            // 
            this.lstIPs.FormattingEnabled = true;
            this.lstIPs.Location = new System.Drawing.Point(12, 92);
            this.lstIPs.Name = "lstIPs";
            this.lstIPs.ScrollAlwaysVisible = true;
            this.lstIPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstIPs.Size = new System.Drawing.Size(283, 95);
            this.lstIPs.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(134, 193);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 334);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(283, 110);
            this.txtConsole.TabIndex = 6;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "List of IP Addresses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Console Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ping Interval (Minutes)";
            // 
            // numudInterval
            // 
            this.numudInterval.Location = new System.Drawing.Point(233, 222);
            this.numudInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numudInterval.Name = "numudInterval";
            this.numudInterval.Size = new System.Drawing.Size(62, 20);
            this.numudInterval.TabIndex = 10;
            this.numudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numudInterval.ValueChanged += new System.EventHandler(this.numudInterval_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current Status:";
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.ForeColor = System.Drawing.Color.Green;
            this.lblRunning.Location = new System.Drawing.Point(176, 287);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(47, 13);
            this.lblRunning.TabIndex = 12;
            this.lblRunning.Text = "Running";
            this.lblRunning.Visible = false;
            // 
            // lblStopped
            // 
            this.lblStopped.AutoSize = true;
            this.lblStopped.ForeColor = System.Drawing.Color.Red;
            this.lblStopped.Location = new System.Drawing.Point(176, 287);
            this.lblStopped.Name = "lblStopped";
            this.lblStopped.Size = new System.Drawing.Size(47, 13);
            this.lblStopped.TabIndex = 13;
            this.lblStopped.Text = "Stopped";
            this.lblStopped.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 282);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(251, 282);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Minimised to tray";
            this.notifyIcon1.BalloonTipTitle = "Ping Timeout Notifications";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Double click to open";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // PingNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 456);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numudInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstIPs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblStopped);
            this.Controls.Add(this.lblRunning);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PingNotification";
            this.Text = "Ping Timeout Notification";
            this.Load += new System.EventHandler(this.Ping_Load);
            this.Resize += new System.EventHandler(this.Ping_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numudInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnAddIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIPs;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numudInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Label lblStopped;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

