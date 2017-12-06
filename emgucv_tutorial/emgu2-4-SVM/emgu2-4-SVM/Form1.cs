using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Diagnostics;
using Emgu.CV.ML;
using Emgu.CV.ML.Structure;

namespace emgu2_4_SVM
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> img;

        public Form1()
        {
            InitializeComponent();
        }

        private void train_button_Click(object sender, EventArgs e)
        {
            //Loading an image
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = new Image<Bgr, byte>(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // PEDESTRAIN DETECTION EXAMPLE
            Rectangle[] regions;
            Image<Bgr, byte> image = img;
                using (HOGDescriptor des = new HOGDescriptor())
                {
                    des.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                    regions = des.DetectMultiScale(image);
                }

            foreach (Rectangle pedestrain in regions)
            {
                image.Draw(pedestrain, new Bgr(Color.Red), 1);
            }
            pictureBox1.Image = image.Bitmap;

        }

        private void defTrain_button_Click(object sender, EventArgs e)
        {

            using (SVM model = new SVM())
            {
                SVMParams p = new SVMParams();
                p.KernelType = Emgu.CV.ML.MlEnum.SVM_KERNEL_TYPE.LINEAR;
                p.SVMType = Emgu.CV.ML.MlEnum.SVM_TYPE.C_SVC;
                p.C = 1;
                p.TermCrit = new MCvTermCriteria(100, 0.00001);

                //bool trained = model.Train(trainData, trainClasses, null, null, p);
                bool trained = model.TrainAuto(trainData, trainClasses, null, null, p.MCvSVMParams, 5);

                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        sample.Data[0, 0] = j;
                        sample.Data[0, 1] = i;

                        float response = model.Predict(sample);

                        img[i, j] =
                           response == 1 ? new Bgr(90, 0, 0) :
                           response == 2 ? new Bgr(0, 90, 0) :
                           new Bgr(0, 0, 90);
                    }
                }

                int c = model.GetSupportVectorCount();
                for (int i = 0; i < c; i++)
                {
                    float[] v = model.GetSupportVector(i);
                    PointF p1 = new PointF(v[0], v[1]);
                    img.Draw(new CircleF(p1, 4), new Bgr(128, 128, 128), 2);
                }
            }

            // display the original training samples
            for (int i = 0; i < (trainSampleCount / 3); i++)
            {
                PointF p1 = new PointF(trainData1[i, 0], trainData1[i, 1]);
                img.Draw(new CircleF(p1, 2.0f), new Bgr(255, 100, 100), -1);
                PointF p2 = new PointF(trainData2[i, 0], trainData2[i, 1]);
                img.Draw(new CircleF(p2, 2.0f), new Bgr(100, 255, 100), -1);
                PointF p3 = new PointF(trainData3[i, 0], trainData3[i, 1]);
                img.Draw(new CircleF(p3, 2.0f), new Bgr(100, 100, 255), -1);
            }

            Emgu.CV.UI.ImageViewer.Show(img);
        }
    }
}
