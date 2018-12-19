using System;

namespace FacadePattern
{
    public class FundCheck
    {
        double cashInAccount = 1000.00;

        public double GetCashInAccount()
        {
            return cashInAccount;
        }

        public void DecreaseCashInAccount(double cashWithDrawn)
        {
            cashInAccount -= cashWithDrawn;
        }

        public void IncreaseCashInAccount(double cashDeposited)
        {
            cashInAccount += cashDeposited;
        }

        public bool HaveEnoughMoney(double cashToWithdrawal)
        {
            if (cashToWithdrawal > GetCashInAccount())
            {
                Console.WriteLine("Error : You don't have enough money");
                Console.WriteLine("Current Balance : " + GetCashInAccount());
                return true;
            }

            Console.WriteLine("Withdrawal Completed : Current Balance is " + GetCashInAccount());
            DecreaseCashInAccount(cashToWithdrawal);
            return true;
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);

            Console.WriteLine("Deposit Completed : Current Balance is " + GetCashInAccount());
        }
    }
}
