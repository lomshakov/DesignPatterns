using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    [Serializable]
    class Circle : IFigure
    {
        int _radius;
        public Point Point { get; set; }
        public Circle(int r, int x, int y)
        {
            _radius = r;
            Point = new Point { X = x, Y = y };
        }
 
        /// <summary>
        /// Сделать поверхностную копию объекта
        /// </summary>
        public IFigure Clone()
        {
            return MemberwiseClone() as IFigure;
        }
 
        /// <summary>
        /// Сделать глубокую копию объекта
        /// </summary>
        public object DeepCopy()
        {
            object figure;
            
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));
 
                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);
 
                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }
        
        /// <summary>
        /// Получить информацию о фигуре
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", _radius, Point.X, Point.Y);
        }
    }
    
    [Serializable]
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
