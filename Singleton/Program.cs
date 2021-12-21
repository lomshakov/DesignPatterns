using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var bell = Bell.Instance;
            bell.Ring();

            Console.ReadKey();
        }
    }
}
