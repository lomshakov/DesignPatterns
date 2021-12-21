using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();
 
            Hero voin = new Hero(new WarriorFactory());
            voin.Hit();
            voin.Run();
 
            Console.ReadLine();
        }
    }
}
