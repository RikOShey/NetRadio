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
    public partial class Channels : Form
    {
        public Channels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtChannelName.Text != "" && txtChannelAddress.Text != "")
            {
                string StrToSave = txtChannelName.Text + "," + txtChannelAddress.Text + Environment.NewLine;
                File.AppendAllText(@".\NetRadio.ini", StrToSave);
                txtChannelName.Clear();
                txtChannelAddress.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
