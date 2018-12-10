namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird()
        {
            setSound("Tweet");

            flyingType = new ItFlys();
        }
    }
}
