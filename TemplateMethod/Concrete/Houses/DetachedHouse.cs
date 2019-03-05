using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete.Houses
{
    public class DetachedHouse : HouseMaker
    {
        public override void AddRoof()
            => Console.WriteLine("Adding a 4 fall roof");
        
        public override void AddWalls()
            => Console.WriteLine("Building 16 walls");
        
        public override void AddWindows()
            => Console.WriteLine("Adding 7 windows!");
    
    }
}
