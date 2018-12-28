namespace ProxyPattern
{
    public class AtmProxy : GetAtmData
    {
        public ATMState GetAtmData()
        {
            AtmMachine realAtm = new AtmMachine();

            return realAtm.GetAtmData();
        }

        public int GetCashInMachine()
        {
            AtmMachine realAtm = new AtmMachine();

            return realAtm.GetCashInMachine();
        }
    }
}
