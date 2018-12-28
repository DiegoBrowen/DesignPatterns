using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class RemoteControl
    {
        private ICommand _slot;

        public RemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }
    }
}
