using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AdjustVolumeCommand : Command
    {
        private Stereo _stereo;

        public AdjustVolumeCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.adjustVolume();
        }
    }
}
