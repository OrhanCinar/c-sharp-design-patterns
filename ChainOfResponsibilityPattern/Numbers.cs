namespace ChainOfResponsibilityPattern
{
    public class Numbers
    {
        int number1;
        int number2;

        string calculationWanted;

        public Numbers(int newNumber1, int newNumber2, string calcWanted)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            calculationWanted = calcWanted;
        }

        public int GetNumber1() { return number1; }

        public int GetNumber2() { return number2; }

        public string GetCalcWanted() { return calculationWanted; }
    }
}
