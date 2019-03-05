using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CalculationStrategies
{
    public interface ICalculatingStrategy
    {
        string Add(string val1, string val2);
        string Substract(string val1, string val2);
    }
}
