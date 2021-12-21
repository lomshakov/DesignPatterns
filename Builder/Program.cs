using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var trucksBuilder = new TrucksCarBuilder();
            Director director = new Director(trucksBuilder);
            
            director.BuildTruck();
            var car = director.GetCar();
            Console.WriteLine(car.isReady);
            
            Console.ReadKey();
        }
    }
}
