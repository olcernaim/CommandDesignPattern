using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TurnOffCommand : Command
    {
        private Device _device;
        public TurnOffCommand(Device device)
        {
            _device = device;
        }
        public void Execute()
        {
            _device.turnOff();
        }
    }
}
