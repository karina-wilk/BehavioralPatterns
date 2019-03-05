using MediatorPattern.Components;
using MediatorPattern.ConcreteComponents;
using MediatorPattern.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var controltower = new JasionkaControlTower();

            FlyingMachine helicopter = new Helicopter();
            FlyingMachine airBus = new Airbus();
            FlyingMachine boeing = new Boeing();

            controltower.Register(helicopter);
            controltower.Register(airBus);
            controltower.Register(boeing);

            helicopter.SendControlMessage();
            Console.WriteLine();
            airBus.SendControlMessage();
            Console.WriteLine();
            boeing.SendControlMessage();

            Console.Read();
        }
    }
}
