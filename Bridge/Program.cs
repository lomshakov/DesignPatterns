using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новую транспортную компанию
            TransportCompanyA transportCompanyA = new TransportCompanyA(new AutoCarrier());
            transportCompanyA.SendPackages();
            transportCompanyA.SendNotification();
            
            // Пришел заказ на перевозку ж/д транспортом
            transportCompanyA.Carrier = new RailwayCarrier();
            transportCompanyA.SendPackages();
            transportCompanyA.SendNotification();
 
            Console.Read();
        }
    }
}
