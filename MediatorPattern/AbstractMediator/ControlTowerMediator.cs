using MediatorPattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.AbstractMediator
{
    public abstract class ControlTowerMediator
    {
        public abstract void Register(FlyingMachine machine);
        public abstract void SendControlMessage(string typeMachine);
    }
}
