using PatternOpenClosedTotal.Class;
using PatternOpenClosedTotal.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Fabric
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculate CreateCalculator(string accountType)
        {
            switch (accountType)
            {
                case "Обычный":
                    return new CalculatorDefault();
                case "Зарплатный":
                    return new CalculatorSalary();
                default:
                    throw new ArgumentException($"Неизвестный тип аккаунта: {accountType}");
            }
        }
    }
}
