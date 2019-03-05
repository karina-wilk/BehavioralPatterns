using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityPattern.AbstractHandler
{
    public abstract class BonusHandler
    {
        protected BonusHandler Next;

        public BonusHandler SetNext(BonusHandler next)
        {
            this.Next = next;
            return next;
        }

        public abstract void Handle(decimal amount);
    }
}
