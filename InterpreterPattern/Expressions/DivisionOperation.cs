using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public class DivisionOperation : IExpression
    {
        private readonly IExpression leftOperand;
        private readonly IExpression rightOperand;

        public DivisionOperation(IExpression leftOperand, IExpression rightOperand)
        {
            this.leftOperand = leftOperand;
            this.rightOperand = rightOperand;
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return this.leftOperand.Interpret(context) / this.rightOperand.Interpret(context);
        }
    }
}
