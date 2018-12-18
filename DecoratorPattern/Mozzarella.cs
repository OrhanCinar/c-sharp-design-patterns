using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mozzarella : ToppingDecorator
    {

        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");

            Console.WriteLine("Adding Moz");
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.50;
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mozarella";
        }
    }
}
