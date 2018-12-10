namespace ObserverPattern
{
    public interface Subject
    {
        void Register(IObserver o);
        void UnRegister(IObserver o);
        void NotifyObserver();
    }
}
