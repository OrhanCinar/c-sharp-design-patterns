using System;

namespace VisitorPattern
{
    public class TaxVisitor : Visitor
    {       
        public double Visit(Liquor liquorItem)
        {
            Console.WriteLine("Liquor item: Pric with Tax");
            return (liquorItem.getPrice() * .18) + liquorItem.getPrice();
        }

        public double Visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Tobacco item: Pric with Tobacco");
            return (tobaccoItem.getPrice() * .32) + tobaccoItem.getPrice();
        }

        public double Visit(Necessity necessityItem)
        {
            Console.WriteLine("Necessity item: Pric with Necessity");
            return (necessityItem.getPrice() * 0) + necessityItem.getPrice();
        }
    }
}
