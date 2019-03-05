using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Expressions
{
    public class Evaluator : IExpression
    {
        private readonly IExpression expressionTree;

        public Evaluator(Context.CalculatorContext context)
        {
            var stack = new Stack<IExpression>();
            foreach (var token in context.Input.Split(' '))
            {
                switch(token)
                {
                    case "*":
                        stack.Push(new MultiplicationOperation(stack.Pop(), stack.Pop()));
                        break;
                    case "/":
                        stack.Push(new DivisionOperation(stack.Pop(), stack.Pop()));
                        break;
                    default:
                        if(Int32.TryParse(token, out int tempInt))
                        stack.Push(new Number(tempInt));
                        break;
                }
            }
            this.expressionTree = stack.Pop();
        }

        public int Interpret(Dictionary<string, IExpression> context)
        {
            return this.expressionTree.Interpret(context);
        }
    }
}
