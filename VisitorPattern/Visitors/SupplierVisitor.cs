using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VisitorPattern.Suppliers;
using VisitorPattern.Suppliers.ConcreteSuppliers;

namespace VisitorPattern.Visitors
{
    public class SupplierVisitor : ISupplierVisitor
    {
        public void PayWithMoneyTransfer(Farmer farmer)
        {
            Console.WriteLine();
            Console.WriteLine($"Amount to pay: {farmer.MoneyToPay}");
            farmer.MoneyToPay = 0;
            Console.WriteLine("Money transfered to farmer...");
            Thread.Sleep(300);
        }

        public void PayForeignSeller(ForeignSeller seller)
        {
            Console.WriteLine();
            Console.WriteLine($"Amount to pay: {seller.MoneyToPay}");
            seller.MoneyToPay -= 100;
            Console.WriteLine($"We send {100/ (seller.MoneyToPay + 100)} part of the whole amnount, to the accounting system of foreign supplier.");
        }

        public void PayCottageIndustrySupplier(ISupplier seller)
        {
            Console.WriteLine();
            Console.WriteLine($"Amount to pay: {seller.MoneyToPay}");
            seller.MoneyToPay = 0;
            Console.WriteLine($"We payed {seller.MoneyToPay} (using micro payment)");
        }

       
    }
}
