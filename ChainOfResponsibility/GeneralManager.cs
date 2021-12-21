using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Старший менеджер
    /// </summary>
    class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}", GetType().Name, purchase.RequestNumber);
            }
            else
            {
                Console.WriteLine("Purchase request #{0} requires an executive meeting!", purchase.RequestNumber);
            }
        }
    }
}