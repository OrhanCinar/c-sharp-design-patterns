using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Sheep : Animal
    {
        public Sheep()
        {
            Console.WriteLine("Sheep is Made");
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Animal MakeCopy()
        {
            Console.WriteLine("Sheep is Being Made");

            Sheep sheepObject = null;

            try
            {
                sheepObject = (Sheep)MemberwiseClone();
            }
            catch (Exception)
            {

                throw;
            }

            return sheepObject;
        }

        public override string ToString()
        {
            return "Dolly is my Hero";
        }
    }
}
