using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();

            Animal tweety = new Bird();

            Console.WriteLine("Dog: " + sparky.tryToFly());

            Console.WriteLine("Bird: " + tweety.tryToFly());

            sparky.setFlyingAbility(new ItFlys());

            Console.WriteLine("Dog: " + sparky.tryToFly());
        }
    }
}
