using MediatorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.ConcreteComponents
{
    class Boeing : FlyingMachine
    {
        public Boeing() : base("Boeing Dreamliner")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("Boeing asks for langing permission");
            controltower.SendControlMessage(name);
        }
    }
}
