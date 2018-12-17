namespace CommandPattern
{
    public interface Command
    {
        void Execute();

        void Undo();
    }
}
