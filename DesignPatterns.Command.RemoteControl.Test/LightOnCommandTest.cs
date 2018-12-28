using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class LightOnCommandTest
    {
        private readonly LightOnCommand _ligthOnCommand;
        public LightOnCommandTest()
        {
            var light = new Light();
            _ligthOnCommand = new LightOnCommand(light);
        }

        [Fact]
        public void LigthOnCommand()
        {
            _ligthOnCommand.Execute();
            Assert.Equal("On", _ligthOnCommand.Result);
        }

        [Fact]
        public void LigthOnCommandFail()
        {
            _ligthOnCommand.Execute();
            Assert.NotEqual(string.Empty, _ligthOnCommand.Result);
        }
    }
}
