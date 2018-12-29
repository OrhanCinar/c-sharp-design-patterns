using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ATMMachine atmMachine = new ATMMachine();

            atmMachine.InsertCard();
            atmMachine.EjectCard();
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(2000);
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);

            Console.ReadKey();
        }
    }
}
