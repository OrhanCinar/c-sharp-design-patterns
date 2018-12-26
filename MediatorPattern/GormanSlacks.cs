using System;

namespace MediatorPattern
{
    public class GormanSlacks : Colleague
    {
        public GormanSlacks(Mediator newMediator) : base(newMediator)
        {
            Console.WriteLine($"Gorman Slacks signed up for the exchange");
        }
    }
}
