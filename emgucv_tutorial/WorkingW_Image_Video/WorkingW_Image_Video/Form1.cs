using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WorkingW_Image_Video
{
    public partial class Form1 : Form
    {

        VideoCapture captureobj;
        bool Pause = false;

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
    }
}
