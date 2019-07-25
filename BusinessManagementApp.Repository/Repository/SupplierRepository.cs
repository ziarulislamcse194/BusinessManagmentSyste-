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

            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplier.Id);
            int isExecuted = 0;

            if (aSupplier != null)
            {
                aSupplier.Code = supplier.Code;
                aSupplier.Name = supplier.Name;
                aSupplier.Address = supplier.Address;
                aSupplier.Email = supplier.Email;
                aSupplier.Contact = supplier.Contact;
                aSupplier.ContactPerson = supplier.ContactPerson;
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }

        public Supplier GetById(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplier.Id);
            return aSupplier;
        }

        public bool Delete(Supplier supplier)
        {
            int isExecuted = 0;
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplier.Id);

            db.Suppliers.Remove(aSupplier);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        

    }
}
