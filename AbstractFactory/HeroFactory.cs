namespace AbstractFactory
{
    /// <summary>
    /// Класс абстрактной фабрики
    /// </summary>
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
    
    /// <summary>
    /// Фабрика создания эльфа (летящего героя с арбалетом)
    /// </summary>
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }

    /// <summary>
    /// Фабрика создания воина (бегущего героя с мечом)
    /// </summary>
    class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}