using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.ReportCreationVisitors;
using VisitorPattern.Visitors;

namespace VisitorPattern.Suppliers.ConcreteSuppliers
{
    public class ForeignSeller : ISupplier
    {
        public string FullName { get; set; }
        public decimal MoneyToPay { get; set; }

        public bool Order(string productCode, int quantity)
        {
            Console.WriteLine($"Hey foreign seller! I order {productCode}, ({quantity} items)");

            //Some operations...
            return true;
        }

        public void SentProductRequest(string productName, int quantity)
            => Console.WriteLine($"Hey foreign seller! Do you have any: {productName}?  I need {quantity} items");

        public void Pay(ISupplierVisitor v)
        {
            v.PayForeignSeller(this);
        }

        public void GenerateReport(IRecordCreator v)
        {
            v.GenerateReport(this);
        }
    }
}
