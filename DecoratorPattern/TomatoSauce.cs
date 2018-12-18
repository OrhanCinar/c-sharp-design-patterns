using System;

namespace DecoratorPattern
{
    public class TomatoSauce : ToppingDecorator
    {

        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");            
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.35;
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Tomato Sauce";
        }
    }
}
