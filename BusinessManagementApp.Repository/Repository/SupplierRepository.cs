using BusinessManagementApp.Models.Models;
using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Repository.Repository
{
    public class SupplierRepository
    {
        BusinessDbContext db = new BusinessDbContext();

        public bool Add(Supplier supplier)
        {
            db.Suppliers.Add(supplier);

            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplier.Id);
            int saved = 0;

            if (aSupplier != null)
            {
                aSupplier.Name = aSupplier.Name;
                saved = db.SaveChanges();
            }

            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Search(Supplier supplier)
        {
            return false;
        }
    }
}
