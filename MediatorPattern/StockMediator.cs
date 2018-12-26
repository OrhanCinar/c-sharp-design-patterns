using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    public class StockMediator : Mediator
    {
        List<Colleague> colleagues;
        List<StockOffer> stockBuyOffers;
        List<StockOffer> stockSellOffers;

        int colleagueCodes = 0;

        public StockMediator()
        {
            colleagues = new List<Colleague>();
            stockBuyOffers = new List<StockOffer>();
            stockSellOffers = new List<StockOffer>();
        }

        public void AddColleague(Colleague newColleague)
        {
            colleagues.Add(newColleague);
            colleagueCodes++;
            newColleague.SetCollCode(colleagueCodes);
        }

        public void BuyOffer(string stock, int shares, int colleagueCode)
        {
            Boolean stockBought = false;

            foreach (var offer in stockSellOffers)
            {
                if (offer.getStockSymbol() == stock && offer.getStockShares() == shares)
                {
                    Console.WriteLine($"{shares} shares of {stock} bought to colleague code {offer.getColleagueCode()}");

                    stockSellOffers.Remove(offer);

                    stockBought = true;
                }

                if (stockBought)
                {
                    break;
                }
            }

            if (!stockBought)
            {
                Console.WriteLine($"{shares} share of {stock} added to inventory ");

                StockOffer newOffering = new StockOffer(shares, stock, colleagueCode);

                stockBuyOffers.Add(newOffering);
            }
        }

        public void SaleOffer(string stock, int shares, int colleagueCode)
        {
            Boolean stockSold = false;

            foreach (var offer in stockBuyOffers)
            {
                if (offer.getStockSymbol() == stock && offer.getStockShares() == shares)
                {
                    Console.WriteLine($"{shares} shares of {stock} sold to colleague code {offer.getColleagueCode()}");

                    stockBuyOffers.Remove(offer);

                    stockSold = true;
                }

                if (stockSold)
                {
                    break;
                }
            }

            if (!stockSold)
            {
                Console.WriteLine($"{shares} share of {stock} added to inventory ");

                StockOffer newOffering = new StockOffer(shares, stock, colleagueCode);

                stockSellOffers.Add(newOffering);
            }
        }

        public void GetStockOfferings()
        {
            Console.WriteLine($"Stock for Sale ");

            foreach (var offer in stockSellOffers)
            {

                Console.WriteLine($"{offer.getStockShares()} shares of {offer.getStockSymbol()}");
            }

            Console.WriteLine($"Stock buy Offers");

            foreach (var offer in stockBuyOffers)
            {
                Console.WriteLine($"{offer.getStockShares()} shares of {offer.getStockSymbol()}");
            }
        }
    }
}
