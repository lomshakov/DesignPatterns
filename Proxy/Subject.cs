using System;

namespace Proxy
{
    public interface ISubject
    {
        void Request();
    }
    
    /// <summary>
    /// Реальный клиент (базовая бизнес-логика)
    /// </summary>
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}