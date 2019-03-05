using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Abstract
{
    public abstract class HouseMaker
    {
        //TemplateMethod
        public void MakeHouse(bool isItSummerHouse)
        {
            if(DigFoundationHole(isItSummerHouse))
            {
                FillFoundationHoleWithConcrete();
            }

            AddWalls();
            AddRoof();
            AddWindows();
        }

        public virtual bool DigFoundationHole(bool isItCottage)
        {
            if (isItCottage)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Digging a hole!");
                return true;
            }
        }

        public virtual void FillFoundationHoleWithConcrete()
            => Console.WriteLine("Pouring concrete into the hole");

        public abstract void AddWalls();

        public abstract void AddWindows();

        public abstract void AddRoof();
    }
}
