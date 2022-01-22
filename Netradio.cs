using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetRadio
{
    public partial class Netradio : Form
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Netradio()
        {
            InitializeComponent();
        }

        private void Netradio_Load(object sender, EventArgs e)
        {
            var stations = File.ReadAllLines(@".\NetRadio.ini").Select(line => line.Split(',')).Select(split => new Station { StreamName = split[0], StreamPath = split[1] }).ToList();

            cBoxChannels.DisplayMember = "StreamName";
            cBoxChannels.ValueMember = "StreamPath";
            cBoxChannels.DataSource = stations;

            cBoxChannels.SelectedIndex = Properties.Settings.Default.LastChannel;
            pBarVolume.Value = Properties.Settings.Default.SetVolume;
            SetPlayerVolume(pBarVolume.Value);
            label1.Text = "Volym: " + pBarVolume.Value.ToString() + "%";
        }

        public static void PlayMusicFromURL(string url)
        {
            player.URL = url;
        }

        public static void PlayerStop(string url)
        {
            player.controls.stop();
        }

        public static void SetPlayerVolume(int volume)
        {
            player.settings.volume = volume;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            if (pBarVolume.Value > 0) pBarVolume.Value -= 10;
            else
            {
                MessageBox.Show("Volymen är nere på noll och kan inte sänkas mer!", "Meddelande...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pBarVolume.Value = 0;
            }
            SetPlayerVolume(pBarVolume.Value);
            label1.Text = "Volym: " + pBarVolume.Value.ToString() + "%";
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            if (pBarVolume.Value < 100) pBarVolume.Value += 10;
            else
            {
                MessageBox.Show("Volymen är på max och kan inte höjas mer!", "Meddelande...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pBarVolume.Value = 100;
            }
            SetPlayerVolume(pBarVolume.Value);
            label1.Text = "Volym: " + pBarVolume.Value.ToString() + "%";
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            if (pBarVolume.Value != 0)
            {
                btnVolumeOff.Tag = pBarVolume.Value;
                pBarVolume.Value = 0;
                SetPlayerVolume(pBarVolume.Value);
            }
            else
            {
                pBarVolume.Value = (int)btnVolumeOff.Tag;
                SetPlayerVolume(pBarVolume.Value);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnStop.Visible = true;
            PlayMusicFromURL(cBoxChannels.SelectedValue.ToString());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Visible = false;
            btnPlay.Visible = true;
            PlayerStop(cBoxChannels.SelectedValue.ToString());
        }

        private void cBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayMusicFromURL(cBoxChannels.SelectedValue.ToString());
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(cBoxChannels.Text.Replace(' ', '_'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Channels NewChannels = new Channels();
            NewChannels.ShowDialog(this);
        }

        private void Netradio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastChannel = cBoxChannels.SelectedIndex;
            Properties.Settings.Default.SetVolume = pBarVolume.Value;
            Properties.Settings.Default.Save();
        }

        private void tsMenuShowHide_Click(object sender, EventArgs e)
        {
            notifyIcon1_DoubleClick(notifyIcon1, null);
        }

        private void tsMenuStop_Click(object sender, EventArgs e)
        {
            btnStop_Click(notifyIcon1, null);
        }

        private void tsMenuPlay_Click(object sender, EventArgs e)
        {
            btnPlay_Click(notifyIcon1, null);
        }

        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastChannel = cBoxChannels.SelectedIndex;
            Properties.Settings.Default.SetVolume = pBarVolume.Value;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }

    class Station
    {
        public string StreamName { get; set; }
        public string StreamPath { get; set; }
    }
}
