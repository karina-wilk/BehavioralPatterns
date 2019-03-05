using MementoPattern.Momento;
using MementoPattern.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern.Caretakers
{
    class Caretaker
    {
        private List<GameCharacterMemento> mementos = new List<GameCharacterMemento>();
        private List<EquipmentMemento> eqMementos = new List<EquipmentMemento>();

        private GameCharacter originator = null;

        public Caretaker(GameCharacter originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            Console.Write(">> Caretaker: Saving character state.");
            
            #region Some dumb animation.
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            this.mementos.Add(this.originator.Save());
            this.eqMementos.Add(this.originator.SaveEquipment());
        }


        public void Undo()
        {
            if (mementos.Count == 0)
            {
                Console.WriteLine("There is no saved copies!");
                return;
            }

            var memento = mementos.Last();
            mementos.Remove(memento);

            Console.WriteLine($">> Caretaker: State from { memento.Date} is restored");

            try
            {
                this.originator.Restore(memento);
            }
            catch (Exception ex)
            {
                this.Undo();
            }
        }

        public void UndoEquipment()
        {
            if (eqMementos.Count == 0)
            {
                Console.WriteLine("No equipment saved copies!");
                return;
            }

            var memento = eqMementos.Last();
            eqMementos.Remove(memento);

            Console.WriteLine($">> Caretaker: State of equipment from { memento.Date} is restored");

            try
            {
                this.originator.Restore(memento);
            }
            catch (Exception ex)
            {
                this.UndoEquipment();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Caretaker: List of saved copies:");

            foreach (var memento in mementos)
            {
                Console.WriteLine(memento.Date);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        public void ShowEquipmentHistory()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Caretaker: List of saved copies:");

            foreach (var memento in eqMementos)
            {
                Console.WriteLine(memento.Date);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }
    }
}
