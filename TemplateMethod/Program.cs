using System;

namespace TemplateMethod
{
    class Program
    {
        // Template Method позволяет абстрактному классу определить каркас алгоритма,
        // при этом оставляя реализацию отдельных шагов в этом алгоритме на усмотрение производных классов.
        static void Main(string[] args)
        {
            Console.WriteLine("Один и тот же клиентский код может работать с разными подклассами:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");
            
            Console.WriteLine("Один и тот же клиентский код может работать с разными подклассами:");
            Client.ClientCode(new ConcreteClass2());

            Console.ReadKey();
        }
    }
}
