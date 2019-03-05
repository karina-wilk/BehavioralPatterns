using MediatorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.ConcreteComponents
{
    class Airbus : FlyingMachine
    {
        public Airbus() : base("Airbus")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("Airbus asks for langing permission");
            controltower.SendControlMessage(name);
        }
    }
}
