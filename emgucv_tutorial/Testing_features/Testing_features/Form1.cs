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
using Emgu.CV.ML;
using Emgu.CV.ML.Structure;

namespace Testing_features
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> img;


        public Form1()
        {
            InitializeComponent();
        }

        private void ReadImg_button_Click(object sender, EventArgs e)
        {
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

            Matrix<float> mat = new Matrix<float>(3, 5);
            label1.Text = "ali";
            // Matrix <Byte> mat = new Matrix<Byte>(img.Rows, img.Cols, img.NumberOfChannels);
            // img.CopyTo(mat);

            label1.Text = label1.Text + "\n";
            //for (int r = 0; r < mat.Rows; r++)
            //{
            //    for (int c = 0; c < mat.Cols; c++)
            //    {
            //        mat.Data[r, c] = 1;
            //    }
            //}
            mat.SetValue(9);
            mat.Data[1, 1] = 55;
            Matrix<float> remat;
            remat = mat.Reshape(1, 1);

            label1.Text = label1.Text + remat.Rows + " \n";
            label1.Text = label1.Text + remat.Cols + " \n";

            //for (int r = 0; r < remat.Rows; r++)
            //{
            //    for (int c = 0; c < remat.Cols; c++)
            //    {
            //        //label1.Text = label1.Text + mat.Data[r, c].ToString()+"II";
            //        label1.Text = label1.Text + remat.Data[r, c].ToString() + "II";

            //    }
            //    label1.Text = label1.Text + "\n LINEE \n";
            //}
        }
    }
}
