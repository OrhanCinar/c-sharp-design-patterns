using System.Collections.Generic;

namespace CommandPattern
{
    public class TurnItAllOff : Command
    {
        List<ElectronicDevice> theDevices;

        public TurnItAllOff(List<ElectronicDevice> newDevices)
        {
            theDevices = newDevices;
        }

        public void Execute()
        {
            foreach (var device in theDevices)
            {
                device.Off();
            }
        }

        public void Undo()
        {
            foreach (var device in theDevices)
            {
                device.On();
            }
        }
    }
}
