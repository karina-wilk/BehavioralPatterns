using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CalculationStrategies
{
    class DecimalCalculatingStrategy : ICalculatingStrategy
    {
        public string Add(string val1, string val2)
        {
            if (Int32.TryParse(val1, out int v1) && Int32.TryParse(val2, out int v2))
            {
                return (v1 + v2).ToString();
            }
            throw new ArgumentException("Wrong input data!");
        }

        public string Substract(string val1, string val2)
        {
            if (Int32.TryParse(val1, out int v1) && Int32.TryParse(val2, out int v2))
            {
                return (v1 - v2).ToString();
            }
            throw new ArgumentException("Wrong input data!");
        }
    }
}
