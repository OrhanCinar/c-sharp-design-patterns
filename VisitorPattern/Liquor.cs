namespace VisitorPattern
{
    public class Liquor : Visitable
    {
        double price;

        public Liquor(double itemPrice)
        {
            price = itemPrice;
        }

        public double Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }

        internal double getPrice()
        {
            return price;
        }
    }
}