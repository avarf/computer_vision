using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Diagnostics;

namespace Pedestrian_detection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            Rectangle[] regions;

            else
            {  //this is the CPU version
                using (HOGDescriptor des = new HOGDescriptor())
                {
                    des.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());

                    watch = Stopwatch.StartNew();
                    regions = des.DetectMultiScale(image);
                }
            }
            watch.Stop();

            processingTime = watch.ElapsedMilliseconds;

            foreach (Rectangle pedestrain in regions)
            {
                image.Draw(pedestrain, new Bgr(Color.Red), 1);
            }
            return image;
        }
    }
}


