using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(30, 50, 60);
            
            // применяем глубокое копирование
            Circle clonedFigure = circle.DeepCopy() as Circle;
            circle.Point.X = 100;
            
            circle.GetInfo();
            clonedFigure.GetInfo();
 
            Console.Read();
        }
    }
}
