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



        private void button1_Click(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref webcam_img);
            webcam.Start();
        }
    }
}
