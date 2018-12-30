using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            TaxVisitor taxCalc = new TaxVisitor();

            Necessity milk = new Necessity(3.47);
            Liquor vodka = new Liquor(11.99);
            Tobacco cigars = new Tobacco(19.99);


            Console.WriteLine($"{milk.Accept(taxCalc)}");
            Console.WriteLine($"{vodka.Accept(taxCalc)}");
            Console.WriteLine($"{cigars.Accept(taxCalc)}");

            Console.ReadKey();
        }
    }
}
