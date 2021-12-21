using System;

namespace Adapter
{
    public interface ITransport
    {
        void Drive();
    }
        
    /// <summary>
    /// Автомобиль
    /// </summary>
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
    
    interface IAnimal
    {
        void Move();
    }
        
    /// <summary>
    /// Верблюд
    /// </summary>
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}