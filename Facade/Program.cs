using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFilter dataFilter = new DataFilter();
            Sender sender = new Sender();
            DataReceiver dataReceiver = new DataReceiver();
         
            DataProcessFacade processFacade = new DataProcessFacade(dataFilter, sender, dataReceiver);
         
            // Создаем и запускаем новое приложение
            DataApp dataApp = new DataApp();
            dataApp.StartApplication(processFacade);
         
            Console.Read();
        }
    }
}
