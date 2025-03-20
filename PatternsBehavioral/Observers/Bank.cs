using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Observers
{
    class Bank : IObserver
    {
        IObservable stock;
        public Bank(IObservable obs)
        {
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object o)
        {
            StockData stockData = (StockData)o;

            if (stockData.Euro > 85)
                Console.WriteLine($"Банк продает евро по курсу {stockData.Euro}");
            else
                Console.WriteLine($"Банк покупает евро по курсу {stockData.Euro}");
        }
    }
}
