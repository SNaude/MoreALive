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
            this.chkScheduled.Location = new System.Drawing.Point(16, 15);
            this.chkScheduled.Margin = new System.Windows.Forms.Padding(4);
            this.chkScheduled.Name = "chkScheduled";
            this.chkScheduled.Size = new System.Drawing.Size(91, 20);
            this.chkScheduled.TabIndex = 0;
            this.chkScheduled.Text = "Scheduled";
            this.chkScheduled.UseVisualStyleBackColor = true;
            this.chkScheduled.CheckedChanged += new System.EventHandler(this.chkScheduled_CheckedChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(172, 42);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(68, 16);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Time";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(172, 75);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(62, 16);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "EndTime";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(124, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(16, 43);
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
            this.txtStartMin.Location = new System.Drawing.Point(84, 43);
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
            this.txtEndMin.Location = new System.Drawing.Point(84, 75);
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
            this.txtEndHour.Location = new System.Drawing.Point(16, 75);
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
            this.txtInterval.Location = new System.Drawing.Point(16, 111);
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
            this.lblInterval.Location = new System.Drawing.Point(172, 111);
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
            this.lblKeyPress.Location = new System.Drawing.Point(172, 146);
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
            this.cBoxKeyPress.Location = new System.Drawing.Point(16, 143);
            this.cBoxKeyPress.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKeyPress.Name = "cBoxKeyPress";
            this.cBoxKeyPress.Size = new System.Drawing.Size(127, 24);
            this.cBoxKeyPress.TabIndex = 14;
            // 
            // chkKeepEndState
            // 
            this.chkKeepEndState.AutoSize = true;
            this.chkKeepEndState.Location = new System.Drawing.Point(16, 174);
            this.chkKeepEndState.Name = "chkKeepEndState";
            this.chkKeepEndState.Size = new System.Drawing.Size(126, 20);
            this.chkKeepEndState.TabIndex = 16;
            this.chkKeepEndState.Text = "Ensure end state";
            this.chkKeepEndState.UseVisualStyleBackColor = true;
            this.chkKeepEndState.CheckedChanged += new System.EventHandler(this.chkKeepEndState_CheckedChanged);
            // 
            // cbEndState
            // 
            this.cbEndState.FormattingEnabled = true;
            this.cbEndState.Location = new System.Drawing.Point(148, 172);
            this.cbEndState.Name = "cbEndState";
            this.cbEndState.Size = new System.Drawing.Size(121, 24);
            this.cbEndState.TabIndex = 17;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.cbEndState);
            this.Controls.Add(this.chkKeepEndState);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox chkKeepEndState;
        private System.Windows.Forms.ComboBox cbEndState;
    }
}