﻿using System;
using System.Windows.Forms;

namespace MoreALive
{
    public partial class Settings : Form
    {

        public static Config config;

        public Settings(ref Config configuration)
        {
            InitializeComponent();
            cbEndState.DataSource = Enum.GetValues(typeof(EndStateEnum));
            cbEndState.SelectedItem = configuration.endState;
            cBoxKeyPress.DataSource = Enum.GetValues(typeof(KeyPressEnum));
            cBoxKeyPress.SelectedItem = configuration.keyPress;
            config = configuration;
            chkScheduled.Checked = config.schedule;
            txtStartHour.Text = config.startHour.ToString();
            txtStartMin.Text = config.startMinute.ToString();
            txtEndHour.Text = config.endHour.ToString();
            txtEndMin.Text = config.endMinute.ToString();
            txtInterval.Text = config.interval.ToString();
            chkKeepEndState.Checked = config.keepEndState;
            chkMon.Checked = config.mon;
            chkTue.Checked = config.tue;
            chkWed.Checked = config.wed;
            chkThu.Checked = config.thu;
            chkFri.Checked = config.fri;

            if (config.keepEndState)
                cbEndState.Enabled = true;
            else
                cbEndState.Enabled = false;

            if (!chkScheduled.Checked)
            {
                gbScheduledSettings.Visible = false;
                txtStartHour.Enabled = false;
                txtStartMin.Enabled = false;
                txtEndHour.Enabled = false;
                txtEndMin.Enabled = false;
                chkMon.Enabled = false;
                chkTue.Enabled = false;
                chkWed.Enabled = false;
                chkThu.Enabled = false;
                chkFri.Enabled = false;
            }
        }

        private void chkScheduled_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkScheduled.Checked)
            {
                gbScheduledSettings.Visible = false;
                txtStartHour.Enabled = false;
                txtStartMin.Enabled = false;
                txtEndHour.Enabled = false;
                txtEndMin.Enabled = false;
                chkMon.Enabled = false;
                chkTue.Enabled = false;
                chkWed.Enabled = false;
                chkThu.Enabled = false;
                chkFri.Enabled = false;
            }
            if (chkScheduled.Checked)
            {
                gbScheduledSettings.Visible = true;
                txtStartHour.Enabled = true;
                txtStartMin.Enabled = true;
                txtEndHour.Enabled = true;
                txtEndMin.Enabled = true;
                chkMon.Enabled = true;
                chkTue.Enabled = true;
                chkWed.Enabled = true;
                chkThu.Enabled = true;
                chkFri.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkScheduled.Checked && (((int)txtStartHour.Value + ((int)txtStartMin.Value / 100)) > ((int)txtEndHour.Value + ((int)txtInterval.Value / 100))))
            {
                toolTip.Show("Start time must be before End time", txtStartHour);
            }
            else
            {
                config.schedule = chkScheduled.Checked;
                config.startHour = (int)txtStartHour.Value;
                config.startMinute = (int)txtStartMin.Value;
                config.endHour = (int)txtEndHour.Value;
                config.endMinute = (int)txtEndMin.Value;
                config.interval = (int)txtInterval.Value;
                config.keyPress = (KeyPressEnum)cBoxKeyPress.SelectedItem;
                config.keepEndState = chkKeepEndState.Checked;
                config.endState = (EndStateEnum)cbEndState.SelectedItem;
                config.mon = chkMon.Checked;
                config.tue = chkTue.Checked;
                config.wed = chkWed.Checked;
                config.thu = chkThu.Checked;
                config.fri = chkFri.Checked;

                config.SaveSettings();
                this.Close();
            }

        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(txtStartHour);
        }

        private void chkKeepEndState_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeepEndState.Checked)
                cbEndState.Enabled = true;
            else
                cbEndState.Enabled = false;
        }
    }
}
