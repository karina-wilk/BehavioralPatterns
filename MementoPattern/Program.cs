using MementoPattern.Momento;
using MementoPattern.Originator;
using MementoPattern.Caretakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> equipment = new List<string>
            {
                "plecak",
                "latarka",
                "nóż",
                "sznurek",
                "kompas",
            };
            GameCharacter originator = new GameCharacter("Lara Kravt", 0, 0, 1, equipment);
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.AddEquipment("buty");
            originator.AddEquipment("kurtka");
            originator.RemoveEquipment("kompas");
            caretaker.Backup();

            originator.AddEquipment("mapa");


            Console.WriteLine();
            caretaker.ShowEquipmentHistory();

            Console.WriteLine();
            caretaker.UndoEquipment();

            Console.WriteLine();
            caretaker.UndoEquipment();


            Console.WriteLine();
            Console.WriteLine("W historii mamy jeszcze następujące wpisy:");
            caretaker.ShowEquipmentHistory();
            Console.Read();
        }

        public void Demo8()
        {
            Console.WriteLine("Tworzymy postać gry. Obecny stan: Lara Kravt, położenie: (0, 0, 1)");
            GameCharacter originator = new GameCharacter("Lara Kravt", 0, 0, 1, new List<string>());
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.Move();

            caretaker.Backup();
            originator.Move();

            caretaker.Backup();
            originator.Move();

            caretaker.Backup();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine();
            caretaker.Undo();

            Console.WriteLine();
            caretaker.Undo();


            Console.WriteLine();
            Console.WriteLine("W historii mamy jeszcze następujące wpisy:");
            caretaker.ShowHistory();
        }
    }
}
