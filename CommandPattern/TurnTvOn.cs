namespace CommandPattern
{
    public class TurnTvOn : Command
    {
        ElectronicDevice theDevice;

        public TurnTvOn(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.On();
        }

        public void Undo()
        {
            theDevice.Off();
        }
    }
}
