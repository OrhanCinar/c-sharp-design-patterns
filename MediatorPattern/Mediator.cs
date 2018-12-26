namespace MediatorPattern
{
    public interface Mediator
    {
        void SaleOffer(string stock, int shares, int colleagueCode);

        void BuyOffer(string stock, int shares, int colleagueCode);

        void AddColleague(Colleague colleague);
    }
}