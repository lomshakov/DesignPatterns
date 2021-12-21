namespace Decorator
{
    /// <summary>
    /// Пицца
    /// </summary>
    abstract class Pizza
    {
        protected Pizza(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public abstract int GetCost();
    }
 
    /// <summary>
    /// Итальянская пицца
    /// </summary>
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
        
    /// <summary>
    /// Американская пицца
    /// </summary>
    class AmericanPizza : Pizza
    {
        public AmericanPizza() : base("Американская пицца")
        { }
        public override int GetCost()
        {
            return 12;
        }
    }
    
    /// <summary>
    /// Пицца с томатами
    /// </summary>
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p) : base(p.Name + ", с томатами", p)
        { }
 
        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
 
    /// <summary>
    /// Пицца с сыром
    /// </summary>
    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p) : base(p.Name + ", с сыром", p)
        { }
 
        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}