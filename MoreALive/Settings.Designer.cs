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
            this.cBoxKeyPress = new System.Windows.Forms.ComboBox();
            this.lblKeyPress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // chkScheduled
            // 
            this.chkScheduled.AutoSize = true;
            this.chkScheduled.Location = new System.Drawing.Point(12, 12);
            this.chkScheduled.Name = "chkScheduled";
            this.chkScheduled.Size = new System.Drawing.Size(77, 17);
            this.chkScheduled.TabIndex = 0;
            this.chkScheduled.Text = "Scheduled";
            this.chkScheduled.UseVisualStyleBackColor = true;
            this.chkScheduled.CheckedChanged += new System.EventHandler(this.chkScheduled_CheckedChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(129, 34);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Time";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(129, 61);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(49, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "EndTime";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(12, 35);
            this.txtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(45, 20);
            this.txtStartHour.TabIndex = 8;
            // 
            // txtStartMin
            // 
            this.txtStartMin.Location = new System.Drawing.Point(63, 35);
            this.txtStartMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(45, 20);
            this.txtStartMin.TabIndex = 9;
            // 
            // txtEndMin
            // 
            this.txtEndMin.Location = new System.Drawing.Point(63, 61);
            this.txtEndMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMin.Name = "txtEndMin";
            this.txtEndMin.Size = new System.Drawing.Size(45, 20);
            this.txtEndMin.TabIndex = 11;
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(12, 61);
            this.txtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(45, 20);
            this.txtEndHour.TabIndex = 10;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(12, 90);
            this.txtInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(96, 20);
            this.txtInterval.TabIndex = 12;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(129, 90);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(42, 13);
            this.lblInterval.TabIndex = 13;
            this.lblInterval.Text = "Interval";
            this.toolTip.SetToolTip(this.lblInterval, "Time in seconds between key presses");
            // 
            // cBoxKeyPress
            // 
            this.cBoxKeyPress.FormattingEnabled = true;
            this.cBoxKeyPress.Location = new System.Drawing.Point(12, 116);
            this.cBoxKeyPress.Name = "cBoxKeyPress";
            this.cBoxKeyPress.Size = new System.Drawing.Size(96, 21);
            this.cBoxKeyPress.TabIndex = 14;
            // 
            // lblKeyPress
            // 
            this.lblKeyPress.AutoSize = true;
            this.lblKeyPress.Location = new System.Drawing.Point(129, 119);
            this.lblKeyPress.Name = "lblKeyPress";
            this.lblKeyPress.Size = new System.Drawing.Size(66, 13);
            this.lblKeyPress.TabIndex = 15;
            this.lblKeyPress.Text = "Key Pressed";
            this.toolTip.SetToolTip(this.lblKeyPress, "Which key will be pressed");
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 184);
            this.Controls.Add(this.lblKeyPress);
            this.Controls.Add(this.cBoxKeyPress);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtEndMin);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.txtStartMin);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.chkScheduled);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}