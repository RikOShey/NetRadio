using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            var stations = File.ReadAllLines(@".\NetRadio.ini").Select(line => line.Split(',')).Select(split => new Station{ StreamName = split[0], StreamPath = split[1]}).ToList();

            cBoxChannels.DisplayMember = "StreamName";
            cBoxChannels.ValueMember = "StreamPath";
            cBoxChannels.DataSource = stations;
            pBarVolume.Value = 50;
            SetPlayerVolume(pBarVolume.Value);
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
            pBarVolume.Value -= 10;
            SetPlayerVolume(pBarVolume.Value);
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            pBarVolume.Value += 10;
            SetPlayerVolume(pBarVolume.Value);
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            pBarVolume.Value = 0;
            SetPlayerVolume(pBarVolume.Value);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            PlayerStop(cBoxChannels.SelectedValue.ToString());
        }

        private void cBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayMusicFromURL(cBoxChannels.SelectedValue.ToString());
            if (cBoxChannels.Text == "Bandit Rock") pictureBox1.Image = Properties.Resources.banditrock;
            if (cBoxChannels.Text == "Lugna Favoriter") pictureBox1.Image = Properties.Resources.lugnafavoriter;
            if (cBoxChannels.Text == "Rix FM") pictureBox1.Image = Properties.Resources.rixfm;
            if (cBoxChannels.Text == "Rock Klassiker") pictureBox1.Image = Properties.Resources.rockklassiker;
            if (cBoxChannels.Text == "Svenska Favoriter") pictureBox1.Image = Properties.Resources.svenskafavoriter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Channels NewChannels = new Channels();
            NewChannels.ShowDialog(this);
        }
    }

    class Station
    {
        public string StreamName { get; set; }
        public string StreamPath { get; set; }
    }
}
