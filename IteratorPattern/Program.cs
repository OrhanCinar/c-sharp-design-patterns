using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggr = new Aggregate();
            aggr.Add("One");
            aggr.Add("Two");
            aggr.Add("Three");
            aggr.Add("Four");

            Iterator iterator = aggr.CreateIterator();

            while (iterator.Next())
            {
                Console.WriteLine(iterator.Current);
            }

            Console.ReadKey();
        }
    }
}
