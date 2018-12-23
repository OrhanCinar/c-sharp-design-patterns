namespace ChainOfResponsibilityPattern
{
    public interface Chain
    {
        void SetNextChain(Chain nextChain);

        void Calculate(Numbers request);
    }
}
