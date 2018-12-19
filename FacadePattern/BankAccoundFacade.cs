using System;

namespace FacadePattern
{
    public class BankAccoundFacade
    {
        int accountNumber;
        int securityCode;

        AccountNumberCheck accChecker;
        SecurityCodeCheck codeChecker;
        FundCheck fundChecker;
        WelcomeToBank bankWelcome;

        public BankAccoundFacade(int newAccountNumber, int newSecurityCode)
        {
            accountNumber = newAccountNumber;
            securityCode = newSecurityCode;

            accChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundCheck();
            bankWelcome = new WelcomeToBank();
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public void WithDrawCash(double cashToGet)
        {
            if (accChecker.AccountActive(GetAccountNumber()) && codeChecker.IsCodeCorrect(GetSecurityCode()) && fundChecker.HaveEnoughMoney(cashToGet))
            {
                Console.WriteLine("Transaction Completed\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }

        public void DepositCash(double cashToDeposit)
        {
            if (accChecker.AccountActive(GetAccountNumber()) && codeChecker.IsCodeCorrect(GetSecurityCode()))
            {
                fundChecker.MakeDeposit(cashToDeposit);
                Console.WriteLine("Transaction Completed\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }
    }
}