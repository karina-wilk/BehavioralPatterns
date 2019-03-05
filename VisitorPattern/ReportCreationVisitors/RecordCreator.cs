using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Suppliers.ConcreteSuppliers;

namespace VisitorPattern.ReportCreationVisitors
{
    public class RecordCreator : IRecordCreator
    {
        public void GenerateReport(Farmer f) => Console.WriteLine("Report for farmer generated");
        public void GenerateReport(CottageIndustrySupplier f) => Console.WriteLine("Report for cottage supplier generated");
        public void GenerateReport(ForeignSeller f) => Console.WriteLine("Report for foreign seller generated");
    }
}
