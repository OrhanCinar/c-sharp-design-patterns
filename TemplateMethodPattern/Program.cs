using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoagie cust12Hoagie = new ItalianHoagie();
            cust12Hoagie.MakeSandwich();


            Hoagie cust13Hoagie = new VeggieHoagie();
            cust13Hoagie.MakeSandwich();

            Console.ReadKey();
        }
    }
}
