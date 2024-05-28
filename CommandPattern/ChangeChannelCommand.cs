using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ChangeChannelCommand : Command
    {
        private TV _tv;

        public ChangeChannelCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.changeChannel();
        }
    }
}
