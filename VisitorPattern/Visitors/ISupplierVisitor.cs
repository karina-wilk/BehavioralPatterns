using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Suppliers;
using VisitorPattern.Suppliers.ConcreteSuppliers;

namespace VisitorPattern.Visitors
{
    public interface ISupplierVisitor
    {
        void PayWithMoneyTransfer(Farmer farmer);
        void PayForeignSeller(ForeignSeller seller);
        void PayCottageIndustrySupplier(ISupplier seller);
    }
}
