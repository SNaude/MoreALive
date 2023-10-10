namespace MoreALive
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblRunning = new System.Windows.Forms.Label();
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbPauseSchedule = new System.Windows.Forms.CheckBox();
            this.ttPauseSchedule = new System.Windows.Forms.ToolTip(this.components);
            this.ttStart = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(87, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Pause";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(87, 87);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Settings";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Location = new System.Drawing.Point(85, 33);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(105, 15);
            this.lblRunning.TabIndex = 2;
            this.lblRunning.Text = "Currently Running";
            this.lblRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ntfIcon
            // 
            this.ntfIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfIcon.BalloonTipText = "More Alive Running";
            this.ntfIcon.BalloonTipTitle = "More Alive";
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "More Alive Running";
            this.ntfIcon.DoubleClick += new System.EventHandler(this.ntfIcon_DoubleClick);
            // 
            // cbPauseSchedule
            // 
            this.cbPauseSchedule.AutoSize = true;
            this.cbPauseSchedule.Location = new System.Drawing.Point(9, 156);
            this.cbPauseSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.cbPauseSchedule.Name = "cbPauseSchedule";
            this.cbPauseSchedule.Size = new System.Drawing.Size(130, 19);
            this.cbPauseSchedule.TabIndex = 3;
            this.cbPauseSchedule.Text = "Disable Scheduler";
            this.cbPauseSchedule.UseVisualStyleBackColor = true;
            this.cbPauseSchedule.CheckedChanged += new System.EventHandler(this.cbPauseSchedule_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 182);
            this.Controls.Add(this.cbPauseSchedule);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "MoreAlive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.CheckBox cbPauseSchedule;
        private System.Windows.Forms.ToolTip ttPauseSchedule;
        private System.Windows.Forms.ToolTip ttStart;
    }
}

