using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMediator nyse = new StockMediator();

            GormanSlacks broker = new GormanSlacks(nyse);

            JTPoorman broker2 = new JTPoorman(nyse);

            broker.SaleOffer("MSFT", 100);
            broker.SaleOffer("GOOG", 50);

            broker2.BuyOffer("MSFT", 100);
            broker2.SaleOffer("NRG", 10);

            broker.BuyOffer("NRG", 10);

            nyse.GetStockOfferings();

            Console.ReadKey();
        }
    }
}
