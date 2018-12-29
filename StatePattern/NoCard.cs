using System;

namespace StatePattern
{
    public class NoCard : ATMState
    {

        ATMMachine atmMachine;

        public NoCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Please Enter a PIN");
            atmMachine.setATMState(atmMachine.GetYesCardState());
        }

        public void EjectCard()
        {
            Console.WriteLine("Enter a card first");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Enter a card first");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter a card first");
        }
    }
}
