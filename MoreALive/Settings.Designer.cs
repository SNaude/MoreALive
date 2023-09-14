namespace MoreALive
{
    partial class Settings
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
            this.chkScheduled = new System.Windows.Forms.CheckBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStartHour = new System.Windows.Forms.NumericUpDown();
            this.txtStartMin = new System.Windows.Forms.NumericUpDown();
            this.txtEndMin = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour = new System.Windows.Forms.NumericUpDown();
            this.txtInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblKeyPress = new System.Windows.Forms.Label();
            this.cBoxKeyPress = new System.Windows.Forms.ComboBox();
            this.chkKeepEndState = new System.Windows.Forms.CheckBox();
            this.cbEndState = new System.Windows.Forms.ComboBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.gbScheduledSettings = new System.Windows.Forms.GroupBox();
            this.gbMainSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            this.gbScheduledSettings.SuspendLayout();
            this.gbMainSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkScheduled
            // 
            this.chkScheduled.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkScheduled.Location = new System.Drawing.Point(0, 0);
            this.chkScheduled.Margin = new System.Windows.Forms.Padding(4);
            this.chkScheduled.Name = "chkScheduled";
            this.chkScheduled.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.chkScheduled.Size = new System.Drawing.Size(372, 31);
            this.chkScheduled.TabIndex = 0;
            this.chkScheduled.Text = "Scheduled";
            this.chkScheduled.UseVisualStyleBackColor = true;
            this.chkScheduled.CheckedChanged += new System.EventHandler(this.chkScheduled_CheckedChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(150, 24);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(68, 16);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Time";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(150, 54);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(62, 16);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "EndTime";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(0, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(372, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(0, 280);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(372, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(14, 22);
            this.txtStartHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(60, 22);
            this.txtStartHour.TabIndex = 8;
            // 
            // txtStartMin
            // 
            this.txtStartMin.Location = new System.Drawing.Point(82, 22);
            this.txtStartMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(60, 22);
            this.txtStartMin.TabIndex = 9;
            // 
            // txtEndMin
            // 
            this.txtEndMin.Location = new System.Drawing.Point(82, 52);
            this.txtEndMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMin.Name = "txtEndMin";
            this.txtEndMin.Size = new System.Drawing.Size(60, 22);
            this.txtEndMin.TabIndex = 11;
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(14, 52);
            this.txtEndHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(60, 22);
            this.txtEndHour.TabIndex = 10;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(14, 22);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(128, 22);
            this.txtInterval.TabIndex = 12;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(149, 24);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(50, 16);
            this.lblInterval.TabIndex = 13;
            this.lblInterval.Text = "Interval";
            this.toolTip.SetToolTip(this.lblInterval, "Time in seconds between key presses");
            // 
            // lblKeyPress
            // 
            this.lblKeyPress.AutoSize = true;
            this.lblKeyPress.Location = new System.Drawing.Point(149, 56);
            this.lblKeyPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeyPress.Name = "lblKeyPress";
            this.lblKeyPress.Size = new System.Drawing.Size(84, 16);
            this.lblKeyPress.TabIndex = 15;
            this.lblKeyPress.Text = "Key Pressed";
            this.toolTip.SetToolTip(this.lblKeyPress, "Which key will be pressed");
            // 
            // cBoxKeyPress
            // 
            this.cBoxKeyPress.FormattingEnabled = true;
            this.cBoxKeyPress.Location = new System.Drawing.Point(14, 53);
            this.cBoxKeyPress.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKeyPress.Name = "cBoxKeyPress";
            this.cBoxKeyPress.Size = new System.Drawing.Size(128, 24);
            this.cBoxKeyPress.TabIndex = 14;
            // 
            // chkKeepEndState
            // 
            this.chkKeepEndState.AutoSize = true;
            this.chkKeepEndState.Location = new System.Drawing.Point(14, 84);
            this.chkKeepEndState.Name = "chkKeepEndState";
            this.chkKeepEndState.Size = new System.Drawing.Size(129, 20);
            this.chkKeepEndState.TabIndex = 16;
            this.chkKeepEndState.Text = "Ensure end state";
            this.chkKeepEndState.UseVisualStyleBackColor = true;
            this.chkKeepEndState.CheckedChanged += new System.EventHandler(this.chkKeepEndState_CheckedChanged);
            // 
            // cbEndState
            // 
            this.cbEndState.FormattingEnabled = true;
            this.cbEndState.Location = new System.Drawing.Point(149, 82);
            this.cbEndState.Name = "cbEndState";
            this.cbEndState.Size = new System.Drawing.Size(121, 24);
            this.cbEndState.TabIndex = 17;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Location = new System.Drawing.Point(14, 81);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(55, 20);
            this.chkMon.TabIndex = 18;
            this.chkMon.Text = "Mon";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Location = new System.Drawing.Point(75, 81);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(53, 20);
            this.chkTue.TabIndex = 19;
            this.chkTue.Text = "Tue";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Location = new System.Drawing.Point(134, 81);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(58, 20);
            this.chkWed.TabIndex = 20;
            this.chkWed.Text = "Wed";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Location = new System.Drawing.Point(198, 81);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(56, 20);
            this.chkThu.TabIndex = 21;
            this.chkThu.Text = "Thur";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(260, 81);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(44, 20);
            this.chkFri.TabIndex = 22;
            this.chkFri.Text = "Fri";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // gbScheduledSettings
            // 
            this.gbScheduledSettings.Controls.Add(this.chkFri);
            this.gbScheduledSettings.Controls.Add(this.txtStartHour);
            this.gbScheduledSettings.Controls.Add(this.chkThu);
            this.gbScheduledSettings.Controls.Add(this.txtStartMin);
            this.gbScheduledSettings.Controls.Add(this.chkWed);
            this.gbScheduledSettings.Controls.Add(this.lblStart);
            this.gbScheduledSettings.Controls.Add(this.chkTue);
            this.gbScheduledSettings.Controls.Add(this.txtEndHour);
            this.gbScheduledSettings.Controls.Add(this.chkMon);
            this.gbScheduledSettings.Controls.Add(this.lblEnd);
            this.gbScheduledSettings.Controls.Add(this.txtEndMin);
            this.gbScheduledSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbScheduledSettings.Location = new System.Drawing.Point(0, 31);
            this.gbScheduledSettings.Name = "gbScheduledSettings";
            this.gbScheduledSettings.Size = new System.Drawing.Size(372, 108);
            this.gbScheduledSettings.TabIndex = 23;
            this.gbScheduledSettings.TabStop = false;
            // 
            // gbMainSettings
            // 
            this.gbMainSettings.Controls.Add(this.txtInterval);
            this.gbMainSettings.Controls.Add(this.cbEndState);
            this.gbMainSettings.Controls.Add(this.chkKeepEndState);
            this.gbMainSettings.Controls.Add(this.lblKeyPress);
            this.gbMainSettings.Controls.Add(this.lblInterval);
            this.gbMainSettings.Controls.Add(this.cBoxKeyPress);
            this.gbMainSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainSettings.Location = new System.Drawing.Point(0, 139);
            this.gbMainSettings.Name = "gbMainSettings";
            this.gbMainSettings.Size = new System.Drawing.Size(372, 113);
            this.gbMainSettings.TabIndex = 24;
            this.gbMainSettings.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 316);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbMainSettings);
            this.Controls.Add(this.gbScheduledSettings);
            this.Controls.Add(this.chkScheduled);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(390, 0);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            this.gbScheduledSettings.ResumeLayout(false);
            this.gbScheduledSettings.PerformLayout();
            this.gbMainSettings.ResumeLayout(false);
            this.gbMainSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkScheduled;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown txtStartHour;
        private System.Windows.Forms.NumericUpDown txtStartMin;
        private System.Windows.Forms.NumericUpDown txtEndMin;
        private System.Windows.Forms.NumericUpDown txtEndHour;
        private System.Windows.Forms.NumericUpDown txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cBoxKeyPress;
        private System.Windows.Forms.Label lblKeyPress;
        private System.Windows.Forms.CheckBox chkKeepEndState;
        private System.Windows.Forms.ComboBox cbEndState;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.GroupBox gbScheduledSettings;
        private System.Windows.Forms.GroupBox gbMainSettings;
    }
}