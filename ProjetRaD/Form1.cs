using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        System.Drawing.Image image_from_webcam;
        Bitmap image_analyse;

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
                //flav.Analyse(image_from_webcam);

                image_analyse = new Bitmap(image_from_webcam);

                analyse.Image = Analyse();
            }
        }

        private void webcam_img_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\Users\Hyksos\Desktop";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image_from_webcam = System.Drawing.Image.FromFile(openFileDialog.FileName);
                webcam_img.Image = image_from_webcam;
            }
        }

        private Bitmap Analyse()
        {
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center colol and radius
            filter.CenterColor = new AForge.Imaging.RGB(Color.FromArgb(215, 30, 30));
            filter.Radius = 100;
            // apply the filter
            filter.ApplyInPlace(image_analyse);


            BitmapData objectsData = image_analyse.LockBits(new Rectangle(0, 0, image_analyse.Width, image_analyse.Height), ImageLockMode.ReadOnly, image_analyse.PixelFormat);
            // grayscaling
            UnmanagedImage grayImage = new Grayscale(0.2125, 0.7154, 0.0721).Apply(new UnmanagedImage(objectsData)); //grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            // unlock image
            image_analyse.UnlockBits(objectsData);

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ProcessImage(grayImage);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            foreach (Rectangle recs in rects)
                if (rects.Length > 0)
                {
                    foreach (Rectangle objectRect in rects)
                    {

                        Graphics g = Graphics.FromImage(image_analyse);

                        using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                        {
                            g.DrawRectangle(pen, objectRect);
                        }

                        g.Dispose();
                    }

                } 

            return image_analyse;
        }
    }
}
