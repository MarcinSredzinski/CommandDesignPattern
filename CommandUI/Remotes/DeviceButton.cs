using System;
using System.Collections.Generic;
using System.Text;
using CommandUI.Contracts;

namespace CommandUI.Remotes
{
    public class DeviceButton
    {
        Contracts.ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }
        public void Press()
        {
            _command.Execute();
        }
        public void PressUndo()
        {
            _command.UnExecute();
        }
    }
}
