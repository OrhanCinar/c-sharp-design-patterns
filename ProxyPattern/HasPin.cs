using System;

namespace ProxyPattern
{
    internal class HasPin : ATMState
    {
        private AtmMachine atmMachine;

        public HasPin(AtmMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter mote than one card");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atmMachine.setATMState(atmMachine.GetNoCardState());
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Already entered PIN");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if (cashToWithdraw > atmMachine.cashInMachine)
            {
                Console.WriteLine("Don't have that Cash");
                Console.WriteLine("Card Ejected");
                atmMachine.setATMState(atmMachine.GetNoCardState());
            }
            else
            {
                Console.WriteLine($"{cashToWithdraw} is provided by the machine");
                atmMachine.setCashInMachine(atmMachine.cashInMachine - cashToWithdraw);

                Console.WriteLine("Card Ejected");
                atmMachine.setATMState(atmMachine.GetNoCardState());

                if (atmMachine.cashInMachine <= 0)
                {
                    atmMachine.setATMState(atmMachine.GetNoCashState());
                }
            }
        }
    }
}