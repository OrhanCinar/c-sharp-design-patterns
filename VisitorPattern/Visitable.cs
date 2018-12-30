namespace VisitorPattern
{
    public interface Visitable
    {
        double Accept(Visitor visitor);
    }
}
