using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.ElectronicDevices
{
    public class TV : Contracts.IElectronicDevice
    {
        private int volume = 0;
        private bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }        

        public void TurnOff()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            IsOn = false;
            Console.WriteLine("TV is now off");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TurnOn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IsOn = true;
            Console.WriteLine("TV is now on");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void VolumeDown()
        {
            if (IsOn)
            {
                volume--;
                Console.WriteLine("TV volume is at:" + volume);
            }
        }

        public void VolumeUp()
        {
            if (IsOn)
            {
                volume++;
                Console.WriteLine("TV volume is at:" + volume);
            }
        }
    }
}
