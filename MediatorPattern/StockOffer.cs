namespace MediatorPattern
{
    public class StockOffer
    {
        private int stockShares;
        private string StockSymbol;
        private int colleagueCode;

        public StockOffer(int numberOfShares, string stock, int collCode)
        {
            stockShares = numberOfShares;
            StockSymbol = stock;
            colleagueCode = collCode;
        }

        public int getStockShares()
        {
            return stockShares;
        }

        public string getStockSymbol()
        {
            return StockSymbol;
        }

        public int getColleagueCode()
        {
            return colleagueCode;
        }
    }
}
