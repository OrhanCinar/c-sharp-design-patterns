namespace VisitorPattern
{
    public class Necessity : Visitable
    {
        double price;

        public Necessity(double itemPrice)
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