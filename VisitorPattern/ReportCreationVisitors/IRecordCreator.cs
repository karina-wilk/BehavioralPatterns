using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Suppliers.ConcreteSuppliers;

namespace VisitorPattern.ReportCreationVisitors
{
    public interface IRecordCreator
    {
        void GenerateReport(Farmer f);
        void GenerateReport(CottageIndustrySupplier f);
        void GenerateReport(ForeignSeller f);
    }
}
