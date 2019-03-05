using MementoPattern.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Momento
{
    class GameCharacterMemento
    {
        private string characterName;
        private int currenPositionX;
        private int currenPositionY;
        private int currenPositionZ;
        private List<string> equipment;

        private DateTime date;

        public GameCharacterMemento(string characterName, int currenPositionX, int currenPositionY, int currenPositionZ, List<string> equipment)
        {
            this.characterName = characterName;
            this.currenPositionX = currenPositionX;
            this.currenPositionY = currenPositionY;
            this.currenPositionZ = currenPositionZ;
            this.equipment = new List<string>();
            this.equipment.AddRange(equipment);

            this.date = DateTime.Now;
        }

        public GameCharacter State => new GameCharacter(characterName, currenPositionX, currenPositionY, currenPositionZ, equipment);
        public DateTime Date => this.date;
    }
}
