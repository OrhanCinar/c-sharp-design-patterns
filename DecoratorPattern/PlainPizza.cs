namespace DecoratorPattern
{
    public class PlainPizza : Pizza
    {
        public double GetCost()
        {
            return 4.00;
        }

        public string GetDescription()
        {
            return "Thin Dough";
        }
    }
}
