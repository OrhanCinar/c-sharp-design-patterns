using System;

namespace TemplateMethodPattern
{
    public class ItalianHoagie : Hoagie
    {
        string[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
        string[] cheeseUsed = { "Provolone" };
        string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        string[] condimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese()
        {
            Console.WriteLine("Adding the  Cheese:");

            foreach (var item in cheeseUsed)
            {
                Console.WriteLine(item + " ");
            }
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding the  Condiment:");

            foreach (var item in condimentsUsed)
            {
                Console.WriteLine(item + " ");
            }
        }

        public override void AddMeat()
        {
            Console.WriteLine("Adding the  Meat:");

            foreach (var meat in meatUsed)
            {
                Console.WriteLine(meat + " ");
            }
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding the  Veggie:");

            foreach (var item in veggiesUsed)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
