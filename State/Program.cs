using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.ReadKey();
        }
    }
}
