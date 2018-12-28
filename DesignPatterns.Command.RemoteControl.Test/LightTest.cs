using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Command.RemoteControl.Test
{
    public class LightTest
    {
        private readonly Light _light;
        public LightTest()
        {
            _light = new Light();
        }

        [Fact]
        public void LigthOnTest()
        {
            Assert.Equal("On", _light.On());
        }

        [Fact]
        public void LigthOnTestFail()
        {
            Assert.NotEqual("", _light.On());
        }

        [Fact]
        public void LigthOffTest()
        {
            Assert.Equal("Off", _light.Off());
        }

        [Fact]
        public void LigthOffTestFail()
        {
            Assert.NotEqual("", _light.Off());
        }
    }
}
