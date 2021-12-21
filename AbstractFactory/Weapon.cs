using System;

namespace AbstractFactory
{
    /// <summary>
    /// Оружие
    /// </summary>
    public abstract class Weapon
    {
        /// <summary>
        /// Атаковать
        /// </summary>
        public abstract void Hit();
    }

    /// <summary>
    /// Арбалет
    /// </summary>
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }

    /// <summary>
    /// Меч
    /// </summary>
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}