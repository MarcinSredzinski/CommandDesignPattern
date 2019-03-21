using CommandUI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.Commands
{
    class TurnVolumeDown : Contracts.ICommand
    {
        Contracts.IElectronicDevice _device;

        public TurnVolumeDown(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeDown();
        }

        public void UnExecute()
        {
            _device.VolumeUp();
        }
    }
}
