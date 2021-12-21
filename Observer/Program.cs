using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем издателя и двух подписчиков
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            // Отписываем одного из наблюдателей
            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadKey();
        }
    }
}
