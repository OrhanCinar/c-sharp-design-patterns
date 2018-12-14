using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CloneFactory animalMaker = new CloneFactory();

            Sheep sally = new Sheep();

            Sheep clonedSheep = (Sheep)animalMaker.GetClone(sally);

            Console.WriteLine(sally);

            Console.WriteLine(clonedSheep);

            Console.WriteLine($"Sally Hashcode {sally.GetHashCode()}");

            Console.WriteLine($"Cloned Hashcode {clonedSheep.GetHashCode()}");

            Console.ReadKey();
        }
    }
}
