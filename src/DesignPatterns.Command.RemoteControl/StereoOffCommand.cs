using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;
        public string Result { get; private set; }
        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            Result = _stereo.Off();
            Console.WriteLine(Result);
        }

        public void Undo()
        {
            Result = _stereo.On();
            Console.WriteLine(Result);
        }
    }
}
