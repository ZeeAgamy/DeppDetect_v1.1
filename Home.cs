using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeppDetect_v1._1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signature_Click(object sender, EventArgs e)
        {
            Signature signForm = new Signature();
            signForm.Show();
            this.Hide();
        }

        private void video_Click(object sender, EventArgs e)
        {
            Video videoForm = new Video();
            videoForm.Show();
            this.Hide();
        }

        private void audio_Click(object sender, EventArgs e)
        {
            Audio audioForm = new Audio();
            audioForm.Show();
            this.Hide();
        }
    }
}
