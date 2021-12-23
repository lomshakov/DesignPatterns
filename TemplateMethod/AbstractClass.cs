using System;

namespace TemplateMethod
{
    // Абстрактный Класс определяет шаблонный метод, содержащий скелет
    // некоторого алгоритма, состоящего из вызовов (обычно) абстрактных
    // примитивных операций. Конкретные подклассы должны реализовать эти операции, но оставить сам
    // шаблонный метод без изменений.
    abstract class AbstractClass
    {
        // Шаблонный метод определяет скелет алгоритма.
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        // Эти операции уже имеют реализации.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass: Я делаю большую часть работы");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass: Но я позволяю подклассам переопределять некоторые операции");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass: Но я все равно делаю основную работу");
        }
        
        // А эти операции должны быть реализованы в подклассах.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();
        
        // Это «хуки». Подклассы могут переопределять их, но это не обязательно,
        // поскольку у хуков уже есть стандартная (но пустая) реализация. Хуки
        // предоставляют дополнительные точки расширения в некоторых критических
        // местах алгоритма.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}