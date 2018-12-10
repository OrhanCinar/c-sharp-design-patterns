using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAAPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);
            stockGrabber.UnRegister(observer1);

            StockObserver observer2 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAAPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);
           
            Console.ReadKey();
        }
    }
}
