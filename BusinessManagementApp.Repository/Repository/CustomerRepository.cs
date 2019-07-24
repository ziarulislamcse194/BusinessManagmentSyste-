using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementApp.Models.Models;

namespace BusinessManagementApp.Repository.Repository
{
    public class CustomerRepository
    {
        BusinessDbContext db = new BusinessDbContext();

        public bool Add(Customer customer)
        {
            db.Customers.Add(customer);

            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            int saved = 0;

            if (aCustomer != null)
            {
                aCustomer.Name = aCustomer.Name;
                saved = db.SaveChanges();
            }

            if (saved > 0)
            {
                return true;
            }

            return false;
        }
    }
}
