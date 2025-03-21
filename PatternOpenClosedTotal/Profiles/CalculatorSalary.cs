using PatternOpenClosedTotal.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Class
{
    class CalculatorSalary : ICalculate
    {
        public void Calculate(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
