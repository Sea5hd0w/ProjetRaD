using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCharpWebCam;

namespace ProjetRaD
{
    public partial class Form1 : Form
    {
        WebCam webcam;

        public Form1()
        {
            InitializeComponent();

            Form flav = new Form2();
            flav.Show();
        }



        private void start_webcam_Click(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref webcam_stream);
            webcam.Start();
        }

        private void capture_image_Click(object sender, EventArgs e)
        {
            webcam_img.Image = webcam_stream.Image;
        }
    }
}
