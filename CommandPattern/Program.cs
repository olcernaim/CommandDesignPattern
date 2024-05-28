using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Stereo stereo = new Stereo();

            Command turnOnTvCommand = new TurnOnCommand(tv);
            Command turnOffTvCommand = new TurnOffCommand(tv);

            Command adjustVolumeStereoCommand = new AdjustVolumeCommand(stereo);
            Command changeChannelTVCommand = new ChangeChannelCommand(tv);

            RemoteControl remote = new RemoteControl();

            remote.setCommand(turnOnTvCommand);
            remote.pressButton();

            remote.setCommand(adjustVolumeStereoCommand);
            remote.pressButton();

            remote.setCommand(changeChannelTVCommand);
            remote.pressButton();

            remote.setCommand(turnOffTvCommand);
            remote.pressButton();
        }
    }
}
