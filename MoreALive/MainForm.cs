using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreALive
{
    public partial class MainForm : Form
    {

        MoreAliveThread moreAliveThread = null;
        Config config = new Config();
        //Program program = new Program();
        public MainForm()
        {
            InitializeComponent();

            ttPauseSchedule.SetToolTip(cbPauseSchedule, "Disables the scheduler to let MoreAlive run freely");
            ttStart.SetToolTip(btnStart, "Pause MoreAlive preventing it from keeping your pc Alive");

            config.Setup();
            cbPauseSchedule.Checked = config.PauseScheduler;
            moreAliveThread = new MoreAliveThread();
            moreAliveThread.ThreadMain(ref config);
            ChangeText();
        }

        bool started = true;


        public void btnStart_Click(object sender, EventArgs e)
        {
            if (started)
            {
                ttStart.SetToolTip(btnStart, "Start running MoreAlive keeping your pc Alive");
                btnStart.Text = "Start";
                lblRunning.Text = "Currently Paused";
                moreAliveThread.Stop();
                started = false;
                ntfIcon.Text = "More Alive Paused";
                ntfIcon.BalloonTipText = "More Alive Paused";
            }
            else
            {
                ttStart.SetToolTip(btnStart, "Pause MoreAlive preventing it from keeping your pc Alive");
                btnStart.Text = "Pause";
                ChangeText();
                moreAliveThread.Start();
                started = true;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(ref config);
            settings.Disposed += CloseSettings;
            settings.Show();
        }

        private void CloseSettings(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ntfIcon.Visible = true;
            }
        }

        private void ntfIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            ntfIcon.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            moreAliveThread.Stop();
            System.Environment.Exit(1);
        }

        private void cbPauseSchedule_CheckedChanged(object sender, EventArgs e)
        {
            config.PauseScheduler = cbPauseSchedule.Checked;
            ChangeText();
        }

        public void ChangeText()
        {
            if (!config.schedule || Common.CheckRun(config))
            {
                lblRunning.Text = "Currently Running";
                ntfIcon.Text = "More Alive Running";
                ntfIcon.BalloonTipText = "More Alive Running";
            }
            else
            {
                lblRunning.Text = "Paused by scheduler";
                ntfIcon.Text = "More Alive Paused by scheduler";
                ntfIcon.BalloonTipText = "More Alive Paused by scheduler";
            }
        }
    }
}
