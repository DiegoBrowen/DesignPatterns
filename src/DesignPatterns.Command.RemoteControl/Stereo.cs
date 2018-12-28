using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class Stereo
    {
        public int Volume { get; private set; }

        public string On()
        {
            return "Stero on";
        }


        public string SetCd()
        {
            return "Set cd";
        }

        public string SetVolume(int volume)
        {
            Volume = volume;
            return $"Set volume {volume}";
        }
    }
}
