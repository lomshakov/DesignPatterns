using System;

namespace AbstractFactory
{
    /// <summary>
    /// Движение
    /// </summary>
    public abstract class Movement
    {
        /// <summary>
        /// Перемещаться
        /// </summary>
        public abstract void Move();
    }

    /// <summary>
    /// Дмижение в воздухе
    /// </summary>
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим по воздуху");
        }
    }

    /// <summary>
    /// Движение на земле
    /// </summary>
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим по земле");
        }
    }
}