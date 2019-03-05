using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public class Number : IExpression
    {
        private readonly int number;

        public Number(int number)
            => this.number = number;

        public int Interpret(Dictionary<string, IExpression> context)
            => number;
    }
}
