using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private Command _command;

        public void setCommand(Command command)
        {
            _command = command;
        }
        public void pressButton()
        {
            _command.Execute();
        }
    }
}
