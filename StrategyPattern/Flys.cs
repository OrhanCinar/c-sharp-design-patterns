namespace StrategyPattern
{
    public interface IFlys
    {
        string Fly();
    }

    public class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
