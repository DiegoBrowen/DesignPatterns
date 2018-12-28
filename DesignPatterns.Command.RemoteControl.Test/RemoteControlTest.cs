using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class RemoteControlTest
    {
        private readonly LightOffCommand _ligthOffCommand;
        private readonly LightOnCommand _ligthOnCommand;
        private readonly StereoOnWithCdCommand _stereoOnWithCdCommand;
        private readonly StereoOffCommand _stereoOffCommand;

        public RemoteControlTest()
        {
            var light = new Light();

            _ligthOffCommand = new LightOffCommand(light);
            _ligthOnCommand = new LightOnCommand(light);

            var stereo = new Stereo();
            _stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            _stereoOffCommand = new StereoOffCommand(stereo);
        }

        [Fact]
        public void RemoteControlSetCommand()
        {
            var remoteControl = new RemoteControl();
            remoteControl.SetCommand(0, _ligthOnCommand, _ligthOffCommand);
            remoteControl.SetCommand(1, _stereoOnWithCdCommand, _stereoOffCommand);

            Assert.Contains(_ligthOnCommand.GetType().FullName, remoteControl.ToString());
            Assert.Contains(_ligthOffCommand.GetType().FullName, remoteControl.ToString());
            Assert.Contains(_stereoOnWithCdCommand.GetType().FullName, remoteControl.ToString());
            Assert.Contains(_stereoOffCommand.GetType().FullName, remoteControl.ToString());
        }

        [Fact]
        public void RemoteControlFail()
        {
            var remoteControl = new RemoteControl();
            remoteControl.SetCommand(0, _ligthOnCommand, _ligthOffCommand);
            remoteControl.SetCommand(1, _stereoOnWithCdCommand, _stereoOffCommand);
            Assert.NotEmpty(remoteControl.ToString());
        }
    }
}
