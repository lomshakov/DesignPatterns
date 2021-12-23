using System;

namespace TemplateMethod
{
    // Конкретные классы должны реализовать все абстрактные операции базового
    // класса. Они также могут переопределить некоторые операции с реализацией
    // по умолчанию.
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1: Implemented Operation2");
        }
    }
}