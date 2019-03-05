using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Abstract;
using TemplateMethod.Concrete;
using TemplateMethod.Concrete.Houses;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseMaker myHouse = new DetachedHouse();
            myHouse.MakeHouse(false);

            Console.WriteLine();
            HouseMaker block = new BlockOfFlats();
            block.MakeHouse(false);

            Console.WriteLine();
            HouseMaker mySummerHouse = new DetachedHouse();
            myHouse.MakeHouse(true);

            Console.Read();
        }
    }
}
