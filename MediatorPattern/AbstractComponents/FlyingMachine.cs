using MediatorPattern.AbstractMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Components
{
    public abstract class FlyingMachine
    {
        protected string name;
        public string Name
        {
            get => name; 
        }

        protected ControlTowerMediator controltower;
        public ControlTowerMediator ControlTower
        {
            set => controltower = value; 
            get => controltower; 
        }

        public FlyingMachine(string name) => this.name = name;

        public abstract void SendControlMessage();
        
    }
}
