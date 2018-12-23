using System;

namespace ChainOfResponsibilityPattern
{
    public class DivideNumbers : Chain
    {
        Chain nextInChain;

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "div")
            {
                Console.WriteLine($"{request.GetNumber1()} / {request.GetNumber2()} = {request.GetNumber1() / request.GetNumber2()}");
            }
            else
            {
                Console.WriteLine("Only workd for add, sub, mult and div");
            }
        }

        public void SetNextChain(Chain nextChain)
        {
            this.nextInChain = nextChain;
        }
    }
}
