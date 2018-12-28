using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class LightOffCommandTest
    {
        private readonly LightOffCommand _ligthOffCommand;
        public LightOffCommandTest()
        {
            var light = new Light();
            _ligthOffCommand = new LightOffCommand(light);
        }

        [Fact]
        public void LigthOnCommand()
        {
            _ligthOffCommand.Execute();
            Assert.Equal("Off", _ligthOffCommand.Result);
        }

        [Fact]
        public void LigthOnCommandFail()
        {
            _ligthOffCommand.Execute();
            Assert.NotEqual(string.Empty, _ligthOffCommand.Result);
        }
    }
}
