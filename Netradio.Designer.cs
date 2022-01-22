
namespace NetRadio
{
    partial class Netradio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Netradio));
            this.cBoxChannels = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.pBarVolume = new System.Windows.Forms.ProgressBar();
            this.btnVolumeOff = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSong = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxChannels
            // 
            this.cBoxChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxChannels.FormattingEnabled = true;
            this.cBoxChannels.Location = new System.Drawing.Point(396, 20);
            this.cBoxChannels.Name = "cBoxChannels";
            this.cBoxChannels.Size = new System.Drawing.Size(196, 24);
            this.cBoxChannels.TabIndex = 0;
            this.cBoxChannels.SelectedIndexChanged += new System.EventHandler(this.cBoxChannels_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVolumeUp);
            this.groupBox1.Controls.Add(this.btnVolumeDown);
            this.groupBox1.Controls.Add(this.pBarVolume);
            this.groupBox1.Controls.Add(this.btnVolumeOff);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radiokanal";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volym";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeUp.Image")));
            this.btnVolumeUp.Location = new System.Drawing.Point(163, 275);
            this.btnVolumeUp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(26, 18);
            this.btnVolumeUp.TabIndex = 6;
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeDown.Image")));
            this.btnVolumeDown.Location = new System.Drawing.Point(46, 275);
            this.btnVolumeDown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(26, 18);
            this.btnVolumeDown.TabIndex = 5;
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // pBarVolume
            // 
            this.pBarVolume.Location = new System.Drawing.Point(47, 264);
            this.pBarVolume.Name = "pBarVolume";
            this.pBarVolume.Size = new System.Drawing.Size(141, 10);
            this.pBarVolume.TabIndex = 4;
            // 
            // btnVolumeOff
            // 
            this.btnVolumeOff.Image = global::NetRadio.Properties.Resources.volumeoff;
            this.btnVolumeOff.Location = new System.Drawing.Point(11, 263);
            this.btnVolumeOff.Name = "btnVolumeOff";
            this.btnVolumeOff.Size = new System.Drawing.Size(31, 31);
            this.btnVolumeOff.TabIndex = 3;
            this.btnVolumeOff.UseVisualStyleBackColor = true;
            this.btnVolumeOff.Click += new System.EventHandler(this.btnVolumeOff_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(291, 263);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 31);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(291, 263);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 31);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::NetRadio.Properties.Resources.internetradio;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Dubbeklicka för att visa!";
            this.notifyIcon1.BalloonTipTitle = "NetRadio";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NetRadio";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuShowHide,
            this.tsMenuStop,
            this.tsMenuPlay,
            this.toolStripSeparator1,
            this.tsMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 114);
            // 
            // tsMenuShowHide
            // 
            this.tsMenuShowHide.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuShowHide.Image")));
            this.tsMenuShowHide.Name = "tsMenuShowHide";
            this.tsMenuShowHide.Size = new System.Drawing.Size(191, 26);
            this.tsMenuShowHide.Text = "Visa/Dölj";
            this.tsMenuShowHide.Click += new System.EventHandler(this.tsMenuShowHide_Click);
            // 
            // tsMenuStop
            // 
            this.tsMenuStop.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuStop.Image")));
            this.tsMenuStop.Name = "tsMenuStop";
            this.tsMenuStop.Size = new System.Drawing.Size(191, 26);
            this.tsMenuStop.Text = "Pausa Musik";
            this.tsMenuStop.Click += new System.EventHandler(this.tsMenuStop_Click);
            // 
            // tsMenuPlay
            // 
            this.tsMenuPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuPlay.Image")));
            this.tsMenuPlay.Name = "tsMenuPlay";
            this.tsMenuPlay.Size = new System.Drawing.Size(191, 26);
            this.tsMenuPlay.Text = "Spela Musik";
            this.tsMenuPlay.Click += new System.EventHandler(this.tsMenuPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuExit.Image")));
            this.tsMenuExit.Name = "tsMenuExit";
            this.tsMenuExit.Size = new System.Drawing.Size(191, 26);
            this.tsMenuExit.Text = "Avsluta Program";
            this.tsMenuExit.Click += new System.EventHandler(this.tsMenuExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSong
            // 
            this.lblSong.Location = new System.Drawing.Point(396, 283);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(225, 23);
            this.lblSong.TabIndex = 4;
            this.lblSong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(413, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            // 
            // Netradio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 328);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBoxChannels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Netradio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InternetRadio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Netradio_FormClosing);
            this.Load += new System.EventHandler(this.Netradio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxChannels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVolumeOff;
        private System.Windows.Forms.ProgressBar pBarVolume;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuShowHide;
        private System.Windows.Forms.ToolStripMenuItem tsMenuStop;
        private System.Windows.Forms.ToolStripMenuItem tsMenuPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.Timer timer1;
    }
}

