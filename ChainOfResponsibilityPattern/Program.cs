using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Chain chainCalc1 = new AddNumbers();
            Chain chainCalc2 = new SubtractNumbers();
            Chain chainCalc3 = new MultNumbers();
            Chain chainCalc4 = new DivideNumbers();


            chainCalc1.SetNextChain(chainCalc2);
            chainCalc2.SetNextChain(chainCalc3);
            chainCalc3.SetNextChain(chainCalc4);

            Numbers request = new Numbers(4, 2, "add");

            chainCalc1.Calculate(request);

            Console.ReadKey();
        }
    }
}
