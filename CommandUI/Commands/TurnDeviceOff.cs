using CommandUI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.Commands
{
    class TurnDeviceOff : Contracts.ICommand
    {
        private Contracts.IElectronicDevice _device;

        public TurnDeviceOff(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOff();
        }

        public void UnExecute()
        {
            _device.TurnOn();
        }
    }
}
