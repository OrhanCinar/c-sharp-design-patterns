namespace CommandPattern
{
    public class TurnTvUp : Command
    {
        ElectronicDevice theDevice;

        public TurnTvUp(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.VolumeUp();
        }

        public void Undo()
        {
            theDevice.volumeDown();
        }
    }
}
