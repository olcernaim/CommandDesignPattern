using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stereo : Device
    {
        public void turnOff()
        {
            Console.WriteLine("Sterio is now off.");
        }
        public void turnOn()
        {
            Console.WriteLine("Sterio is now on.");
        }
        public void adjustVolume()
        {
            Console.WriteLine("Volume adjusted");
        }
    }
}
