using System;
using System.Collections.Generic;
using System.Text;
using CommandUI.Contracts;

namespace CommandUI.Commands
{
    public class TurnDeviceOn : Contracts.ICommand
    {
       private Contracts.IElectronicDevice _device;

        public TurnDeviceOn(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }

        public void UnExecute()
        {
            _device.TurnOff();
        }
    }
}
