using System;
using System.Collections.Generic;
using System.Text;
using CommandUI.Contracts;

namespace CommandUI.Commands
{
    public class TurnVolumeUp : Contracts.ICommand
    {
        Contracts.IElectronicDevice _device;

        public TurnVolumeUp(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }

        public void UnExecute()
        {
            _device.VolumeDown();
        }
    }
}
