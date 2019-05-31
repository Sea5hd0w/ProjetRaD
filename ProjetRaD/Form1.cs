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
        Form flav;
        WebCam webcam;
        bool webcam_start;
        Image image_from_webcam;

        public Form1()
        {
            InitializeComponent();

            image_from_webcam = null;
            webcam_start = false;

            flav = new Form2();
            flav.Show();
        }

        private void start_webcam_Click(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref webcam_stream);
            webcam.Start();
            webcam_start = true;
        }

        private void capture_image_Click(object sender, EventArgs e)
        {
            if(webcam_start)
            {
                webcam_img.Image = webcam_stream.Image;
                image_from_webcam = webcam_img.Image;
            }
        }

        private void start_analyse_Click(object sender, EventArgs e)
        {
            if(image_from_webcam != null)
            {
                flav.Analyse(image_from_webcam);
            }
        }
    }
}
