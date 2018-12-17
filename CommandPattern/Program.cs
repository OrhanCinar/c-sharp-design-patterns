using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice newDevice = TvRemote.GetDevice();

            TurnTvOn onCommand = new TurnTvOn(newDevice);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.Press();

            //off
            TurnTvOff ofCommand = new TurnTvOff(newDevice);

            onPressed = new DeviceButton(ofCommand);

            onPressed.Press();


            //volume
            TurnTvUp volUpCommand = new TurnTvUp(newDevice);

            onPressed = new DeviceButton(volUpCommand);

            onPressed.Press();
            onPressed.Press();
            onPressed.Press();

            //radio
            Television theTv = new Television();

            Radio theRadio = new Radio();

            List<ElectronicDevice> allDevices = new List<ElectronicDevice>();

            allDevices.Add(theTv);
            allDevices.Add(theRadio);

            TurnItAllOff turnOffDevices = new TurnItAllOff(allDevices);

            DeviceButton turnThemOff = new DeviceButton(turnOffDevices);

            turnThemOff.Press();


            //undo

            turnThemOff.PressUndo();

            Console.ReadKey();
        }
    }
}
