using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WorkingW_Image_Video
{
    public partial class Form1 : Form
    {
        List<Image<Bgr, byte>> allimages = new List<Image<Bgr, byte>>();
        private FolderBrowserDialog folderBrowserDialog1;
        VideoCapture captureobj;
        bool Pause = false;
        int imnum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr, byte> img = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = img.Bitmap;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void playToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            captureobj = new VideoCapture(0);
            Mat m = new Mat();
            Pause = false;

            while (!Pause)
            {
                captureobj.Read(m);
                if (!m.IsEmpty)
                {
                    pictureBox2.Image = m.Bitmap;
                    double fps = captureobj.GetCaptureProperty(
                        Emgu.CV.CvEnum.CapProp.Fps);
                    if (fps == 0)
                    {
                        fps = 10;
                    }
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pause = !Pause;
        }

        private void loadDir_button_Click(object sender, EventArgs e)
        {
            // read all the files names in a directory
            // Show the FolderBrowserDialog.
            string folderName = string.Empty;
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
            }

            // get the files list
            string[] fileEntries = Directory.GetFiles(folderName);
            //foreach (string fileName in fileEntries)
            //    textBox1.Text = textBox1.Text + "\n"+fileName;

            // load each image into a matrix and store each matrix in a list/arraylist
            //Image<Bgr, byte> img = new Image<Bgr, byte>(ofd.FileName);
            // List<Image<Bgr, byte>> allimages = new List<Image<Bgr, byte>>();
            foreach (string file in fileEntries)
            {
                allimages.Add(new Image<Bgr, byte>(file));
            }

            // Show the first image
            pictureBox1.Image = allimages[imnum].Bitmap;
            imnum += 1;
            // each time that I press next image button it increase a counter and shows the next image


        }

        private void NxtImg_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = allimages[imnum].Bitmap;
            imnum += 1;
        }
    }
}
