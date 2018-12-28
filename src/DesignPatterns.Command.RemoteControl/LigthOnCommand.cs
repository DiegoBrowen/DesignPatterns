using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class LigthOnCommand : ICommand
    {
        private readonly Light _light;
        public LigthOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
