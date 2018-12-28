namespace ProxyPattern
{
    public interface ATMState
    {
        void InsertCard();

        void EjectCard();

        void InsertPin(int pinEntered);

        void RequestCash(int cashToWithdraw);
    }
}
