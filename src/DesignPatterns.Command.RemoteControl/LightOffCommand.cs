using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public string Result { get; private set; }

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            Result = _light.Off();
            Console.WriteLine(Result);
        }
    }
}
