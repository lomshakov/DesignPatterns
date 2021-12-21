using System;

namespace Observer
{
    public interface IObserver
    {
        // Получает обновление от издателя
        void Update(ISubject subject);
    }

    // Конкретные Наблюдатели реагируют на обновления, выпущенные Издателем, к
    // которому они прикреплены.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {            
            if (((Subject)subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State == 0 || ((Subject)subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}