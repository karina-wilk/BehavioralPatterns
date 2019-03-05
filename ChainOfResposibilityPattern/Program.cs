using ChainOfResposibilityPattern.AbstractHandler;
using ChainOfResposibilityPattern.ConcreteHandlers.BonusAcceptationHanlders;
using System;

namespace ChainOfResposibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusHandler pm = new PM();
            BonusHandler departmentDirector = new DepartmentDirector();
            BonusHandler financeDirector = new FinanceDirector();
            BonusHandler ceo = new CEO();

            pm.SetNext(departmentDirector).SetNext(financeDirector).SetNext(ceo);

            pm.Handle(80);
            Console.WriteLine();
            pm.Handle(1230);
            Console.WriteLine();
            pm.Handle(2450);

            Console.Read();
        }
    }
}
