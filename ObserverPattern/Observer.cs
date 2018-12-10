namespace ObserverPattern
{
    public interface IObserver 
    {
        void Update(double ibmPrice, double applPrice, double googPrice);
    }
}
