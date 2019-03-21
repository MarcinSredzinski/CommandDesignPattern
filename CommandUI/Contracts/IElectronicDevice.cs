using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.Contracts
{
    public interface IElectronicDevice
    {
        bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
        void VolumeUp();
        void VolumeDown();
    }
}
