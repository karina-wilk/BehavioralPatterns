using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete.Houses
{
    public class BlockOfFlats : HouseMaker
    {
        public override void AddRoof()
            => Console.WriteLine("Adding a metal roof");
        
        public override void AddWalls()
            => Console.WriteLine("Building 120 walls");
        
        public override void AddWindows()
            => Console.WriteLine("Adding 230 windows and balcony doors!");
    
    }
}
