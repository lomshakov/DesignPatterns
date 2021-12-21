using System;

namespace Facade
{
    class DataApp
    {
        public void StartApplication(DataProcessFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
    
    /// <summary>
    /// Фильтр данных
    /// </summary>
    class DataFilter
    {
        public void CreateFilter()
        {
            Console.WriteLine("Создан фильтр");
        }
        public void Filter()
        {
            Console.WriteLine("Данные успешно отфильтрованы");
        }
    }
        
    /// <summary>
    /// Отправить данные
    /// </summary>
    class Sender
    {
        public void Send()
        {
            Console.WriteLine("Отправление данных");
        }
    }
        
    /// <summary>
    /// Получить данные
    /// </summary>
    class DataReceiver
    {
        public void Receive()
        {
            Console.WriteLine("Получение результата...");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}