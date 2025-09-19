using InterpreterPattern;
using System;

namespace DPM225460_LeNhatQuang_Example15_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            // Xây dựng biểu thức: (true OR false) AND true
            IExpression expr = new AndExpression(
                                    new OrExpression(
                                        new LiteralExpression(true),
                                        new LiteralExpression(false)
                                    ),
                                    new LiteralExpression(true)
                                );

            bool result = expr.Interpret(context);
            Console.WriteLine("(true OR false) AND true = " + result);
        }
    }
}
