using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Менеджер закупок
    /// </summary>
    class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}", GetType().Name, purchase.RequestNumber);
            }
            else
            {
                Supervisor?.ProcessRequest(purchase);
            }
        }
    }
}