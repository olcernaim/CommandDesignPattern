﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TurnOnCommand : Command
    {
        private Device _device;
        public TurnOnCommand(Device device)
        {
            _device = device;
        }
        public void Execute()
        {
            _device.turnOn();
        }
    }
}
