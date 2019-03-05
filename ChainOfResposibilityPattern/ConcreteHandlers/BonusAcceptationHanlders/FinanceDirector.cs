using ChainOfResposibilityPattern.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.ConcreteHandlers.BonusAcceptationHanlders
{
    public class FinanceDirector : BonusHandler
    {
        public override void Handle(decimal request)
        {
            if(request < 1_000)
            {
                Console.WriteLine($"Finance director accepted amount {request}");
            }
            else
            {
                Next.Handle(request);
            }
        }
    }
}
