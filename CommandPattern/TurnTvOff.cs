namespace CommandPattern
{
    public class TurnTvOff : Command
    {
        ElectronicDevice theDevice;

        public TurnTvOff(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.Off();
        }

        public void Undo()
        {
            theDevice.On();
        }
    }
}
