using System;

namespace BridgePattern
{
    public class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            DeviceState = newDeviceState;
            MaxSetting = newMaxSetting;
        }

        public override void ButtonFivePressed()
        {
            Console.WriteLine("Channeld Down");

            DeviceState--;
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine("Channeld Up");

            DeviceState++;
        }
    }
}
