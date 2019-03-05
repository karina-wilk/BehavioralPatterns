using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.ReportCreationVisitors;
using VisitorPattern.Visitors;

namespace VisitorPattern.Suppliers.ConcreteSuppliers
{
    public class Farmer : ISupplier
    {
        public string FullName { get; set; }
        public decimal MoneyToPay { get; set; }

        public bool Order(string productCode, int quantity)
        {
            Console.WriteLine($"Hey farmer! I order {productCode} ({quantity} pieces)");

            //Some operations...
            return true;
        }

        public void SentProductRequest(string productName, int quantity)
            => Console.WriteLine($"Hey farmer! Do you have any: {productName}?  I need {quantity} pieces");

        public void Pay(ISupplierVisitor v)
        {
            v.PayWithMoneyTransfer(this);
        }

        public void GenerateReport(IRecordCreator v)
        {
            v.GenerateReport(this);
        }
    }
}
