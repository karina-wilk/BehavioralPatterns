using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CalculationStrategies
{
    class BinaryCalculatingStrategy : ICalculatingStrategy
    {
        public string Add(string val1, string val2)
        {
            int v1 = Convert.ToInt32(val1, 2);
            int v2 = Convert.ToInt32(val2, 2);

            return Convert.ToString((v1 + v2), 2);
        }

        public string Substract(string val1, string val2)
        {
            int v1 = Convert.ToInt32(val1, 2);
            int v2 = Convert.ToInt32(val2, 2);

            return Convert.ToString((v1 - v2), 2);
        }
    }
}
