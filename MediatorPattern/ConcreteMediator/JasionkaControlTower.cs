using MediatorPattern.AbstractMediator;
using MediatorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.ConcreteMediator
{
    public class JasionkaControlTower: ControlTowerMediator
    {
        private Dictionary<string, FlyingMachine> machines = new Dictionary<string, FlyingMachine>();

        public override void Register(FlyingMachine machine)
        {
            if (!machines.ContainsValue(machine))
            {
                machines[machine.Name] = machine;
            }

            machine.ControlTower = this;
        }

        public override void SendControlMessage(string name)
        {
            var machine = machines[name];

            if (machine != null)
            {
                if (name == "Boeing Dreamliner")
                {
                    Console.WriteLine($"Sorry {name}, you are to big for our airport! Fly to another one!");
                }
                else
                {
                    Console.WriteLine($"OK {machine.Name}, you can land now!");
                    foreach (var m in machines.Where(c => c.Key != name).ToList())
                    {
                        Console.WriteLine($"Hey {m.Key}, watch out! {machine.Name} is landing!");
                    }
                }
            }
        }
    }
}
