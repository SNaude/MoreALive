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
        Program program = new Program();
        public MainForm()
        {
            InitializeComponent();
            config.Setup();
            cbPauseSchedule.Checked = config.PauseScheduler;
            moreAliveThread = new MoreAliveThread();
            moreAliveThread.ThreadMain(ref config);
        }

        bool started = true;


        public void btnStart_Click(object sender, EventArgs e)
        {
            if (started)
            {
                btnStart.Text = "Start";
                lblRunning.Text = "Currently Paused";
                moreAliveThread.Stop();
                started = false;
                ntfIcon.Text = "More Alive Paused";
                ntfIcon.BalloonTipText = "More Alive Paused";
            }
            else
            {
                btnStart.Text = "Pause";
                lblRunning.Text = "Currently Running";
                moreAliveThread.Start();
                started = true;
                ntfIcon.Text = "More Alive Running";
                ntfIcon.BalloonTipText = "More Alive Running";
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(ref config);
            settings.Show();

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
        }
    }
}
