using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TV : Device
    {
        public void turnOff()
        {
            Console.WriteLine("Tv is now off.");
        }
        public void turnOn()
        {
            Console.WriteLine("Tv is now on.");
        }
        public void changeChannel()
        {
            Console.WriteLine("Channel changed.");
        }
    }
}
