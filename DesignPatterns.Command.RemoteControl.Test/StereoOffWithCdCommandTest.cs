using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class StereoOffWithCdCommandTest
    {
        private readonly StereoOffCommand _stereoOffCommand;
        public StereoOffWithCdCommandTest()
        {
            var stereo = new Stereo();
            _stereoOffCommand = new StereoOffCommand(stereo);
        }

        [Fact]
        public void StereoOnWithCdCommand()
        {
            _stereoOffCommand.Execute();
            Assert.Contains("Stero off", _stereoOffCommand.Result);
        }

        [Fact]
        public void StereoOnWithCdCommanFail()
        {
            _stereoOffCommand.Execute();
            Assert.NotEqual(string.Empty, _stereoOffCommand.Result);
        }
    }
}
