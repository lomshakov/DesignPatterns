using System;

namespace Bridge
{
    interface ICarrier
    {
        void AcceptShipment();
        void Send();
    }
 
    /// <summary>
    /// Авто-Перевозчик
    /// </summary>
    class AutoCarrier : ICarrier
    {
        public void AcceptShipment()
        {
            Console.WriteLine("Принимаем отправление для отправки автотранспортом");
        }
 
        public void Send()
        {
            Console.WriteLine("Отправляем авто-доставкой");
        }
    }
 
    /// <summary>
    /// РЖД
    /// </summary>
    class RailwayCarrier : ICarrier
    {
        public void AcceptShipment()
        {
            Console.WriteLine("Принимаем отправление для отправки железнодорожным транспортом");
        }
 
        public void Send()
        {
            Console.WriteLine("Отправляем груз через РЖД");
        }
    }
}