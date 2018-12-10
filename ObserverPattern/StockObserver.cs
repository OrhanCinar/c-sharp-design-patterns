using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StockObserver : IObserver
    {
        private double ibmPrice;
        private double applPrice;
        private double googPrice;

        private static int observerIDTracker;

        private int observerID;

        private Subject stockGrabber;


        public StockObserver(Subject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            observerID = ++observerIDTracker;

            Console.WriteLine($"New Observer {observerID}");

            stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double applPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.applPrice = applPrice;
            this.googPrice = googPrice;

            PrintThePrices();
        }

        private void PrintThePrices()
        {
            Console.WriteLine($"{observerID} \nIBM: {ibmPrice} \nAAPL: {applPrice} \nGOOG: {googPrice}");
        }
    }
}
