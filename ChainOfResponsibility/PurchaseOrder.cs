using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Ордер на закупку
    /// </summary>
    class PurchaseOrder
    {
        public PurchaseOrder(int number, double amount, double price, string name)
        {
            RequestNumber = number;
            Amount = amount;
            Price = price;
            Name = name;

            Console.WriteLine("Purchase request for " + name + " (" + amount + " for $" + price + ") has been submitted.");
        }

        public int RequestNumber { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}