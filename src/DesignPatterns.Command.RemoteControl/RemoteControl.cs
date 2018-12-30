using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.RemoteControl
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> _onCommands;
        private Dictionary<int, ICommand> _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new Dictionary<int, ICommand>();
            _offCommands = new Dictionary<int, ICommand>();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands.Add(slot, onCommand);
            _offCommands.Add(slot, offCommand);
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var text = new StringBuilder("------Remote control------");
            foreach (var onCommand in _onCommands)
            {
                var offCommand = _offCommands[onCommand.Key];
                text.AppendLine($"[slot {onCommand.Key}] -> { onCommand.Value }");
                text.AppendLine($"[slot {onCommand.Key}] -> { offCommand }");
            }
            return text.ToString();
        }
    }
}
