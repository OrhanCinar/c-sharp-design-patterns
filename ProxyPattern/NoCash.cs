using System;

namespace ProxyPattern
{
    internal class NoCash : ATMState
    {
        private AtmMachine atmMachine;

        public NoCash(AtmMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("We don't have money");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have money. Yo didn't enter a card");
        }
      
        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We don't have money");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We don't have money");
        }
    }
}