using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("Первый");
            collection.AddItem("Второй");
            collection.AddItem("Третий");

            Console.WriteLine("Нормальный порядок:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nОбратный порядок:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
