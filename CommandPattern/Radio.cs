using System;

namespace CommandPattern
{
    public class Radio : ElectronicDevice
    {
        int volume;

        public void Off()
        {
            Console.WriteLine("Radio is off");
        }

        public void On()
        {
            Console.WriteLine("Radio is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine($"Radio Volume is at {volume}");
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine($"Radio volume is at {volume}");
        }
    }
}
