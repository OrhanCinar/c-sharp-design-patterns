using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockGrabber : Subject
    {
        readonly List<IObserver> observers;

        double ibmPrice;
        double aaplPrice;
        double googPrice;

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }

      
        public void Register(IObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void UnRegister(IObserver newObserver)
        {
            var idx = observers.IndexOf(newObserver);

            observers.Remove(newObserver);

            Console.WriteLine($"Observer {idx+1} deleted");
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void setIBMPrice(double newPrice)
        {
            ibmPrice = newPrice;
            NotifyObserver();
        }

        public void setAAPLPrice(double newPrice)
        {
            aaplPrice = newPrice;
            NotifyObserver();
        }

        public void setGOOGPrice(double newPrice)
        {
            googPrice = newPrice;
            NotifyObserver();
        }
    }
}
