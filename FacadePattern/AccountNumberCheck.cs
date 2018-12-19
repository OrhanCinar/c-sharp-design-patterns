namespace FacadePattern
{
    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public bool AccountActive(int accountNumToCheck)
        {
            if (accountNumToCheck == GetAccountNumber())
            {
                return true;
            }

            return false;
        }
    }
}
