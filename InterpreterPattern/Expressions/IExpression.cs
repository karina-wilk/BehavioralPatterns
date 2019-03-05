using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public interface IExpression
    {
        int Interpret(Dictionary<string, IExpression> context);
    }
}
