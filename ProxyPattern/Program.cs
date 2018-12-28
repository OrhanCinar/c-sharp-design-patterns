using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmMachine atmMachine = new AtmMachine();

            atmMachine.InsertCard();
            atmMachine.EjectCard();
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(2000);
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);

            GetAtmData realAtmMachine = new AtmMachine();

            GetAtmData atmProxy = new AtmProxy();

            Console.WriteLine($"Current ATM State {atmProxy.GetAtmData()}");

            Console.WriteLine($"Cash in ATM Machine {atmProxy.GetCashInMachine()}");
                     
            Console.ReadKey();
        }
    }
}
