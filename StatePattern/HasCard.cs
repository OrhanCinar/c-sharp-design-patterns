using System;

namespace StatePattern
{
    internal class HasCard : ATMState
    {
        ATMMachine atmMachine;

        public HasCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atmMachine.setATMState(atmMachine.GetNoCardState());
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter mote than one card");
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Correct PIN");

                atmMachine.correctPinEntered = true;
                atmMachine.setATMState(atmMachine.GetHasPinState());
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                atmMachine.correctPinEntered = false;

                Console.WriteLine("Card Ejected");
                atmMachine.setATMState(atmMachine.GetNoCardState());
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter PIN First");
        }
    }
}