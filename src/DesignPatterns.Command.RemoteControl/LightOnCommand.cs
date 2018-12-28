using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public string Result { get; private set; }

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            Result = _light.On();
        }
    }
}
