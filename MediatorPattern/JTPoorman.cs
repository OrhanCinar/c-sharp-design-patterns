using System;

namespace MediatorPattern
{
    public class JTPoorman : Colleague
    {
        public JTPoorman(Mediator newMediator) : base(newMediator)
        {
            Console.WriteLine($"JTPoorman Slacks signed up for the exchange");
        }
    }
}
