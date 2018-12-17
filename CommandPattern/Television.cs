using System;

namespace CommandPattern
{
    public class Television : ElectronicDevice
    {
        int volume;

        public void Off()
        {
            Console.WriteLine("Tv is off");
        }

        public void On()
        {
            Console.WriteLine("Tv is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine($"Tv Volume is at {volume}");
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine($"Tv volume is at {volume}");
        }
    }
}
