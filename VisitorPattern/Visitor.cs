namespace VisitorPattern
{
    public interface Visitor
    {
        double Visit(Liquor liquorItem);
        double Visit(Tobacco tobaccoItem);
        double Visit(Necessity necessityItem);
    }
}
