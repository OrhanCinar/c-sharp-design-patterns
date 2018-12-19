using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccoundFacade accessingBank = new BankAccoundFacade(12345678,1234);

            accessingBank.WithDrawCash(50.0);
            accessingBank.WithDrawCash(50.0);
            accessingBank.DepositCash(200);

            Console.ReadKey();
        }
    }
}
