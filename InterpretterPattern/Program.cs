using System;
using System.Collections.Generic;

namespace InterpretterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";

            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());


            foreach (var expression in tree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"{roman} - { context.Output}");

            Console.ReadKey();
        }
    }
}
