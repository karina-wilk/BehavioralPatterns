using MediatorPattern.Components;
using System;

namespace MediatorPattern.ConcreteComponents
{
    class Helicopter : FlyingMachine
    {
        public Helicopter() : base("Helicopter")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("Helicopter asks for langing permission");
            controltower.SendControlMessage(name);
        }
    }
}
