using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class RemoteButton
    {
        private EntertainmentDevice theDevice;

        public RemoteButton(EntertainmentDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void ButtonFivePressed()
        {
            theDevice.ButtonFivePressed();
        }

        public void ButtonSixPressed()
        {
            theDevice.ButtonSixPressed();
        }

        public void DeviceFeedback()
        {
            theDevice.DeviceFeedback();
        }

        public abstract void ButtonNinePressed();
    }
}
