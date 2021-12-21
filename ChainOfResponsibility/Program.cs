using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем менеджеров
            Approver jack = new ManagerAssistant();
            Approver mitchell = new PurchasingManager();
            Approver olivia = new GeneralManager();

            // Создаем "цепочку обязанностей"
            jack.SetSupervisor(mitchell);
            mitchell.SetSupervisor(olivia);

            // Создание и обработка платежей
            PurchaseOrder order = new PurchaseOrder(1, 20, 69, "Office paper");
            jack.ProcessRequest(order);

            order = new PurchaseOrder(2, 300, 1389, "PC");
            jack.ProcessRequest(order);

            order = new PurchaseOrder(3, 500, 4823.99, "Another");
            jack.ProcessRequest(order);

            order = new PurchaseOrder(4, 4, 12099, "Building renovation");
            jack.ProcessRequest(order);
            
            Console.ReadKey();
        }    
    }
}