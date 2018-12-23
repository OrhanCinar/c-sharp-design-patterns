using System;

namespace ChainOfResponsibilityPattern
{
    public class AddNumbers : Chain
    {
        Chain nextInChain;

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "add")
            {
                Console.WriteLine($"{request.GetNumber1()} + {request.GetNumber2()} = {request.GetNumber1() + request.GetNumber2()}");
            }
            else
            {
                nextInChain.Calculate(request);
            }
        }

        public void SetNextChain(Chain nextChain)
        {
            this.nextInChain = nextChain;
        }
    }
}
