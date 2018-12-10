using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Dog : Animal
    {
        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }

        public Dog()
        {
            setSound("Bark");

            flyingType = new CantFly();
        }
    }
}
