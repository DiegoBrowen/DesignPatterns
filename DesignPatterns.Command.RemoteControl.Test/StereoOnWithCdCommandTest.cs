using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class StereoOnWithCdCommandTest
    {
        private readonly StereoOnWithCdCommand _stereoOnWithCdCommand;
        public StereoOnWithCdCommandTest()
        {
            var stereo = new Stereo();
            _stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
        }

        [Fact]
        public void StereoOnWithCdCommand()
        {
            _stereoOnWithCdCommand.Execute();
            Assert.Contains("Stero on", _stereoOnWithCdCommand.Result);
            Assert.Contains("Set cd", _stereoOnWithCdCommand.Result);
            Assert.Contains("Set volume", _stereoOnWithCdCommand.Result);
        }

        [Fact]
        public void StereoOnWithCdCommanFail()
        {
            _stereoOnWithCdCommand.Execute();
            Assert.NotEqual(string.Empty, _stereoOnWithCdCommand.Result);
        }
    }
}
