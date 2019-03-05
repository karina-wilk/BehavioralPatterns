using MementoPattern.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Momento
{
    class EquipmentMemento
    {
        private List<string> equipment;

        private DateTime date;

        public EquipmentMemento(List<string> equipment)
        {
            this.equipment = new List<string>();
            this.equipment.AddRange(equipment);

            this.date = DateTime.Now;
        }

        public List<string> State => new List<string>(equipment);
        public DateTime Date => this.date;
    }
}
