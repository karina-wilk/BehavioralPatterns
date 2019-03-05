using MementoPattern.Momento;
using System;
using System.Collections.Generic;

namespace MementoPattern.Originator
{
    class GameCharacter
    {
        public string CharacterName;

        //Private fields!
        private int currenPositionX;
        private int currenPositionY;
        private int currenPositionZ;
        private List<string> equipment;

        public GameCharacter(string characterName, int currenPositionX, int currenPositionY, int currenPositionZ, List<string> equipment)
        {
            this.CharacterName = characterName;
            this.currenPositionX = currenPositionX;
            this.currenPositionY = currenPositionY;
            this.currenPositionZ = currenPositionZ;
            this.equipment = new List<string>();
            this.equipment.AddRange(equipment);
        }

        //Working on private fields!
        //Has to be in this class because of lack of access from 'outside'.
        public void Move()
        {
            this.currenPositionX = new Random().Next(0, 100);
            this.currenPositionY = new Random().Next(2, 100);
            this.currenPositionZ = new Random().Next(1, 10);
            Console.WriteLine($"Character after a move: {CharacterName}, position: ({currenPositionX}, {currenPositionY}, {currenPositionZ})");
        }

        public void AddEquipment(string item)
        {
            this.equipment.Add(item);
        }
        public void RemoveEquipment(string item)
        {
            if (this.equipment.Contains(item))
            {
                this.equipment.Add(item);
            }
            else
            {
                Console.WriteLine("I don't have this equipment!");
            }
        }


        
        public GameCharacterMemento Save()
        {
            return new GameCharacterMemento(CharacterName, currenPositionX, currenPositionY, currenPositionZ, equipment); //Tworzymy kopię (również pola prywatne!)
        }

        public EquipmentMemento SaveEquipment()
        {
            return new EquipmentMemento(equipment); 
        }

        public void Restore(GameCharacterMemento memento)
        {
            var restoredCharacter = memento.State;
            this.CharacterName = restoredCharacter.CharacterName;
            this.currenPositionX = restoredCharacter.currenPositionX;
            this.currenPositionY = restoredCharacter.currenPositionY;
            this.currenPositionZ = restoredCharacter.currenPositionZ;
            this.equipment = new List<string>();
            this.equipment.AddRange(restoredCharacter.equipment);
            
            Console.WriteLine($"GameCharacter: State from backup restored: {CharacterName}, position: ({currenPositionX}, {currenPositionY}, {currenPositionZ})");
        }

        public void Restore(EquipmentMemento memento)
        {
            this.equipment.Clear();
            this.equipment.AddRange(memento.State);

            Console.WriteLine($"GameCharacter: State of equipment restored from backup: ({String.Join(", ", equipment)})");
        }
    }
}
