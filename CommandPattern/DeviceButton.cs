namespace CommandPattern
{
    public class DeviceButton
    {
        Command theCommand;

        public DeviceButton(Command newDevice)
        {
            theCommand = newDevice;
        }

        public void Press()
        {
            theCommand.Execute();
        }

        public void PressUndo()
        {
            theCommand.Undo();
        }
    }
}
