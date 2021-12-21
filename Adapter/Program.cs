using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем путешественника
            Tourist tourist = new Tourist();
            Auto auto = new Auto();
            // Отправляемся в путешествие
            tourist.Travel(auto);
            // Встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // Для этого используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // Продолжаем путь по пескам пустыни
            tourist.Travel(camelTransport);

            Console.ReadKey();
        }
    }
}
