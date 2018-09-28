using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Rule20
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int minute, seconds;
        string m, s;
        bool check = true;
        SoundPlayer player;
        private void frmMain_Load(object sender, EventArgs e)
        {
            pic.Image = Rule20.Properties.Resources.work;
            setTime();

            Stream str = Properties.Resources.relax_app;
            player = new SoundPlayer(str);
        }

        private void btnStartAndStop_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                player.Stop();
                pic.Image = Rule20.Properties.Resources.work;
                setTime();
                timer.Start();
                check = false;
                btnStartAndStop.Text = "Dừng làm việc";
                notifi.Visible = true;
                notifi.BalloonTipText = "Sẽ báo sau " + minute + " phút nữa.";
                notifi.ShowBalloonTip(1000);
                this.Hide();
            }
            else
            {
                timer.Stop();
                check = true;
                btnStartAndStop.Text = "Bắt đầu làm việc";
            }
        }

        private void notifi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifi.Visible = false;
            this.Show();
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifi.Visible = false;
            this.Show();
        }

        private void dừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (check == false)
                {
                    notifi.Visible = true;
                    notifi.BalloonTipText = "Sẽ báo sau " + minute + " phút nữa.";
                    notifi.ShowBalloonTip(10);
                    this.Hide();
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            m = minute >= 10 ? minute + "" : "0" + minute;
            s = seconds >= 10 ? seconds + "" : "0" + seconds;
            lblTime.Text = m + " : " + s;

            if (minute == 0 && seconds == 0)
            {
                player.PlayLooping();
                check = true;
                btnStartAndStop.Text = "Bắt đầu làm việc";
                timer.Stop();
                pic.Image = Rule20.Properties.Resources.relax;
                notifi.Visible = false;
                this.Show();
            }
            if (seconds == 0)
            {
                seconds = 60;
                minute--;
            }
            seconds--;
        }

        private void setTime()
        {
            minute = 20;
            seconds = 0;
        }
    }
}
