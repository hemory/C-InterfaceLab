using System;

namespace InterfaceLabDevX
{
    class RemoteController : IButton
    {
        //Properties
        public bool IsOn { get; set; }
        public int Volume { get; set; }

        //Constructor
        public RemoteController(bool isOn, int volume)
        {
            IsOn = isOn;
            Volume = volume;
        }

        //Methods implemented from IButton
        public void Power(bool isOn)
        {
            if (isOn == true)
            {
                Console.WriteLine("The machine is shutting down");
            }
            else
            {
                Console.WriteLine("The machine is turning on");
            }
        }

        public void VolumeDown()
        {
            if (Volume != 0)
            {
                Volume--;
                Console.WriteLine($"The volume is currently at {Volume} ");
            }
        }

        public void VolumeUp()
        {
            if (Volume != 50)
            {
                Volume++;
                Console.WriteLine($"The volume is currently at {Volume} ");
            }
        }
    }
}


