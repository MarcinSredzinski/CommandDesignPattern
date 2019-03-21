using CommandUI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.Remotes
{
    public class Remote
    {
        public List<DeviceButton> Buttons { get; private set; }
        public Remote(List<DeviceButton> buttons)
        {
            Buttons = buttons;
        }
    }
}
