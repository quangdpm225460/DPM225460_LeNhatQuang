using CommandPattern;
using System;

namespace DPM225460_LeNhatQuang_Example14_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();

            ICommand turnOn = new TurnOnCommand(tv);
            ICommand turnOff = new TurnOffCommand(tv);

            RemoteControl remote = new RemoteControl();

            // Bật TV
            remote.SetCommand(turnOn);
            remote.PressButton();

            // Tắt TV
            remote.SetCommand(turnOff);
            remote.PressButton();
        }
    }
}
