using System;

namespace BridgePattern
{
    public abstract class EntertainmentDevice
    {
        public int DeviceState;

        public int MaxSetting;

        public int VolumeLevel;

        public abstract void ButtonFivePressed();

        public abstract void ButtonSixPressed();

        public void DeviceFeedback()
        {
            if (DeviceState > MaxSetting || DeviceState < 0)
            {
                DeviceState = 0;               
            }

            Console.WriteLine("On " + DeviceState);
        }

        public void ButtonSevenPressed()
        {
            VolumeLevel++;

            Console.WriteLine("Volume at " + VolumeLevel);
        }

        public void ButtonEightPressed()
        {
            VolumeLevel--;

            Console.WriteLine("Volume at " + VolumeLevel);
        }
    }
}
