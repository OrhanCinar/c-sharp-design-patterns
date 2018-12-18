using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine($"Ingredients : {basicPizza.GetDescription()}");

            Console.WriteLine($"Price : {basicPizza.GetCost()}");
           
            Console.ReadKey();
        }
    }
}
