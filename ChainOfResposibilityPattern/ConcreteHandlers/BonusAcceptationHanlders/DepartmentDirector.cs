using ChainOfResposibilityPattern.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.ConcreteHandlers.BonusAcceptationHanlders
{
    public class DepartmentDirector : BonusHandler
    {
        public override void Handle(decimal request)
        {
            if(request < 500)
            {
                Console.WriteLine($"Director accepted amount {request}");
            }
            else
            {
                Next.Handle(request);
            }
        }
    }
}
