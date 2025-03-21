using PatternOpenClosedTotal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOpenClosedTotal.Profiles
{
    class CalculatorDefault : ICalculate
    {
        public void Calculate(Account account)
        {
            if (account.Type == "Обычный")
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance >= 1000)
                    account.Interest -= account.Balance * 0.4;
            }
        }
    }
}
