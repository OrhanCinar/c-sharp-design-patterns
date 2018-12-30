using System;

namespace TemplateMethodPattern
{
    public abstract class Hoagie
    {
        Boolean afterFirstCondiment = false;

        public void MakeSandwich()
        {
            CutBun();

            if (CustomerWantsMeat())
            {
                AddMeat();
                afterFirstCondiment = true;
            }

            if (CustomerWantsCheese())
            {
                if (afterFirstCondiment)
                {
                    Console.WriteLine();
                }
                AddCheese();

                afterFirstCondiment = true;
            }

            if (CustomerWantsVegetables())
            {
                if (afterFirstCondiment)
                {
                    Console.WriteLine();
                }
                AddVegetables();
                afterFirstCondiment = true;
            }

            if (CustomerWantsCondiments())
            {
                if (afterFirstCondiment)
                {
                    Console.WriteLine();
                }
                AddCondiments();
            }


            WrapTheHoogie();
        }

        private void WrapTheHoogie()
        {
            Console.WriteLine("Wrap the Hoagie");
        }

        public bool CustomerWantsCheese()
        {
            return true;
        }

        public bool CustomerWantsMeat()
        {
            return true;
        }

        public bool CustomerWantsVegetables()
        {
            return true;
        }

        public bool CustomerWantsCondiments()
        {
            return true;
        }

        public void CutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        public abstract void AddMeat();

        public abstract void AddCheese();

        public abstract void AddVegetables();

        public abstract void AddCondiments();
    }
}
