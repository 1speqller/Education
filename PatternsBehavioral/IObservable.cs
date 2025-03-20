using PatternObserver.Observers;

namespace PatternObserver
{
    /// <summary>
    /// Интерфейс наблюдаемого объекта (источника информации, на который подписаны наблюдатели)
    /// </summary>
    interface IObservable
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
