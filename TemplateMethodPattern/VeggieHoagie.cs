using System;

namespace TemplateMethodPattern
{
    public class VeggieHoagie : Hoagie
    {

        string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        string[] condimentsUsed = { "Oil", "Vinegar" };

        public new bool CustomerWantsCheese()
        {
            return false;
        }

        public new bool CustomerWantsMeat()
        {
            return false;
        }

        public override void AddCheese()
        {

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

