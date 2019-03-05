using StrategyPattern.CalculationStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose calculation base: 10 , 2 or 16?");

            if (Int32.TryParse(Console.ReadLine(), out int calculatorBase))
            {
                ICalculatingStrategy strategy = null;

                switch (calculatorBase)
                {
                    case 10:
                        strategy = new DecimalCalculatingStrategy();
                        Console.WriteLine($"5+11 = {strategy.Add("5", "11")}");
                        break;
                    case 2:
                        strategy = new BinaryCalculatingStrategy();
                        Console.WriteLine($"10 + 111 = {strategy.Add("10", "111")}");
                        break;
                    case 16:
                        strategy = null;
                        Console.WriteLine($"0xA + 0x11 = {strategy.Add("0xA", "0x11")}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong calculation base!");
            }

            Console.ReadLine();
        }
    }
}
