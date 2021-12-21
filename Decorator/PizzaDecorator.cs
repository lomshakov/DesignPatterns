namespace Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        protected readonly Pizza Pizza;

        protected PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            Pizza = pizza;
        }
    }
}