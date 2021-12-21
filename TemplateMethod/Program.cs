using System;

namespace TemplateMethod
{
    class Program
    {
        // Template Method позволяет абстрактному классу определить каркас алгоритма,
        // при этом оставляя реализацию отдельных шагов в этом алгоритме на усмотрение производных классов.
        static void Main(string[] args)
        {
            TopPart topPart = new TopPart();
            topPart.Make();

            BottomPart bottomPart = new BottomPart();
            bottomPart.Make();

            Console.ReadKey();
        }
    }
}
