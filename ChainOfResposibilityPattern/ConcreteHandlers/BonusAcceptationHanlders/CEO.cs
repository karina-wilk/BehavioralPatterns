using ChainOfResposibilityPattern.AbstractHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.ConcreteHandlers.BonusAcceptationHanlders
{
    public class CEO : BonusHandler
    {
        public override void Handle(decimal request)
        {
            if(request < 2_000)
            {
                Console.WriteLine($"CEO accepted amount {request}");
            }
            else
            {
                Console.WriteLine($"Amount {request} was rejected. Try again in a year!");
            }
        }
    }
}
