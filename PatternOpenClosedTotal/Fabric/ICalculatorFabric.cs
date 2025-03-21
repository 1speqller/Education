using PatternOpenClosedTotal.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Fabric
{
    public interface ICalculatorFactory
    {
        ICalculate CreateCalculator(string accountType);
    }
}
