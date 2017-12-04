using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Emgucv_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\workspace\\git_repos\\datasets\\computer_vision\\modern.jpg";
            Image<Bgr, byte> img = new Image<Bgr, byte>(filename);
            CvInvoke.Imshow("image", img);
            CvInvoke.WaitKey(0);


        }
    }
}
