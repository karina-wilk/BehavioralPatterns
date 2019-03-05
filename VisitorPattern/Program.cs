using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.ReportCreationVisitors;
using VisitorPattern.Suppliers;
using VisitorPattern.Suppliers.ConcreteSuppliers;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISupplierVisitor supplierVisitor = new SupplierVisitor();
            IRecordCreator recordVisitor = new RecordCreator();

            var farmer = new Farmer();
            farmer.MoneyToPay = 1950;
            farmer.Pay(supplierVisitor);
            farmer.GenerateReport(recordVisitor);
            Console.WriteLine($"Amount left to pay FARMER after calling Pay(): {farmer.MoneyToPay}");

            var foreignSeller = new ForeignSeller();
            foreignSeller.MoneyToPay = 50_000;
            foreignSeller.Pay(supplierVisitor);
            foreignSeller.GenerateReport(recordVisitor);
            Console.WriteLine($"Amount left to pay FOREIGN SUPPLIER after calling Pay(): {foreignSeller.MoneyToPay}");

            var cottageIndustrySeller = new CottageIndustrySupplier();
            cottageIndustrySeller.MoneyToPay = 890;
            cottageIndustrySeller.Pay(supplierVisitor);
            cottageIndustrySeller.GenerateReport(recordVisitor);
            Console.WriteLine($"Amount left to pay COTTAGE SUPPLIER after calling Pay(): {cottageIndustrySeller.MoneyToPay}");

            Console.Read();
        }
    }
}
