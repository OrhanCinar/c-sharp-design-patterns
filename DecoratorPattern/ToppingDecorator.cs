namespace DecoratorPattern
{
    public abstract class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;

        public ToppingDecorator(Pizza newPizza)
        {
            tempPizza = newPizza;
        }

        public virtual double GetCost()
        {
            return tempPizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return tempPizza.GetDescription();
        }
    }
}
