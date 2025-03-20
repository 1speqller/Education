using PatternObserver.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatternObserver
{
    /// <summary>
    /// Информация о торгах
    /// </summary>
    class Stock : IObservable
    {
        StockData _stockData;
        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            _stockData = new StockData();
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(_stockData);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Market()
        {
            Random rnd = new Random();
            _stockData.USD = rnd.Next(70, 90);
            _stockData.Euro = rnd.Next(80, 100);

            NotifyObservers();
        }
    }
}
