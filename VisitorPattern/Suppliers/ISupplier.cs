using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.ReportCreationVisitors;
using VisitorPattern.Visitors;

namespace VisitorPattern.Suppliers
{
    public interface ISupplier
    {
        string FullName { get; set; }
        decimal MoneyToPay { get; set; }

        void SentProductRequest(string productName, int quantity);
        bool Order(string productCode, int quantity);
        void Pay(ISupplierVisitor v);
        void GenerateReport(IRecordCreator v);
    }
}
