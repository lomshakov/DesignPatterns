using System;

namespace Builder
{
    /// <summary>
    /// Строитель автомобилей
    /// </summary>
    public abstract class CarBuilder
    {
        protected Car Car;
        public Car GetCar()
        {
            return Car;
        }
        public void CreateNewCar()
        {
            Car = new Car();
        }
        public abstract void BuildCar();
        public abstract void FinallyBuild();
    }
        
    /// <summary>
    /// Строитель грузовиков
    /// </summary>
    public class TrucksCarBuilder : CarBuilder
    {
        public override void BuildCar()
        {
            Console.WriteLine("Start building car...");
            Car.Frame = "Frame of the truck";
            Car.Engine = "Truck Diesel Engine";
            Car.Saloon = "Truck saloon";
            Car.Electric = "High reliability electrical system";
        }
        public override void FinallyBuild()
        {
            Console.WriteLine("Finally operations...");
            Car.Wheels = "315/60 R22";
            Car.SetState(true);
            Console.WriteLine("Car is ready!");
        }
    }
}