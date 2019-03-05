using InterpreterPattern.Context;
using InterpreterPattern.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorContext context = new CalculatorContext();
            context.Input = "12 3 6 / *";

            var evaluator = new Evaluator(context);
            
            context.Output = evaluator.Interpret(new Dictionary<string, IExpression>());
            Console.WriteLine(context.Output);

            Console.ReadKey();
        }
    }
}
