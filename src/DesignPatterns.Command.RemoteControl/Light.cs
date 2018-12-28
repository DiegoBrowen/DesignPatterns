using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class Light
    {
        public string On()
        {
            return "On";
        }

        public string Off()
        {
            return "Off";
        }
    }
}
