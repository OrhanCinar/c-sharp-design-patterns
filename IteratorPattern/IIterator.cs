namespace IteratorPattern
{
    public interface IIterator
    {
        bool Next();
        object Current { get; }
    }
}
