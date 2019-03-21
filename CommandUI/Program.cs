using CommandUI.Contracts;
using System;
using System.Collections.Generic;

namespace CommandUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Experimenting with Command Pattern");

            IElectronicDevice electronicDevice = new ElectronicDevices.TV();
            ICommand deviceOn = new Commands.TurnDeviceOn(electronicDevice);
            ICommand deviceOff = new Commands.TurnDeviceOff(electronicDevice);

            ICommand volumeUp = new Commands.TurnVolumeUp(electronicDevice);
            ICommand volumeDown = new Commands.TurnVolumeDown(electronicDevice);

            Remotes.DeviceButton buttonOn = new Remotes.DeviceButton(deviceOn);
            Remotes.DeviceButton buttonOff = new Remotes.DeviceButton(deviceOff);

            Remotes.DeviceButton deviceVolumeUp = new Remotes.DeviceButton(volumeUp);
            Remotes.DeviceButton deviceVolumeDown = new Remotes.DeviceButton(volumeDown);

            List<Remotes.DeviceButton> buttons = new List<Remotes.DeviceButton> { buttonOn, buttonOff, deviceVolumeUp, deviceVolumeDown };

            Remotes.Remote universalRemote = new Remotes.Remote(buttons);
            Console.WriteLine("Insert number from 0 to 3 to press button on the remote");
            Console.WriteLine("0. Turn on");
            Console.WriteLine("1. Turn off");
            Console.WriteLine("2. Volume up");
            Console.WriteLine("3. Volume down");

            bool keepWorking = true;
            while (keepWorking)
            {
                if (int.TryParse(Console.ReadLine(), out int choosenAction) && 0 <= choosenAction && choosenAction < 4)
                {
                    universalRemote.Buttons[choosenAction].Press();
                    Console.WriteLine("Insert next button:");
                }
                else if (string.Equals(Console.ReadLine(), "exit"))
                {
                    keepWorking = false;
                }
                else
                {
                    Console.WriteLine("There is no such button, try again:");
                }
            }
        }
        private enum Buttons
        {
            deviceOn = 1,
            deviceOff = 2,
            deviceVolumeUp = 3,
            deviceVolumeDown = 4
        }
    }
}
