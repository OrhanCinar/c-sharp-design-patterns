namespace VisitorPattern
{
    public class Tobacco : Visitable
    {
        double price;

        public Tobacco(double itemPrice)
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