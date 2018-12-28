using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;
        public string Result { get; private set; }

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            var result = new StringBuilder();
            result.AppendLine(_stereo.On());
            result.AppendLine(_stereo.SetCd());
            result.AppendLine(_stereo.SetVolume(11));
            Result = result.ToString();
        }
    }
}
