namespace MediatorPattern
{
    public abstract class Colleague
    {
        Mediator mediator;
        int colleagueCode;

        public Colleague(Mediator newMediator)
        {
            mediator = newMediator;

            mediator.AddColleague(this);
        }

        public void SaleOffer(string stock, int shares)
        {
            mediator.SaleOffer(stock, shares, this.colleagueCode);
        }

        public void BuyOffer(string stock, int shares)
        {
            mediator.BuyOffer(stock, shares, this.colleagueCode);
        }

        public void SetCollCode(int collCode)
        {
            colleagueCode = collCode;
        }
    }
}
