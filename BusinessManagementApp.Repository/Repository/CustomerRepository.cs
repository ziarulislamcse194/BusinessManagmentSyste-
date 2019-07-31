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

            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            int isExecuted = 0;

            if (aCustomer != null)
            {
                aCustomer.Code = customer.Code;
                aCustomer.Name = customer.Name;
                aCustomer.Address = customer.Address;
                aCustomer.Email = customer.Email;
                aCustomer.ContactNo = customer.ContactNo;
                aCustomer.LoyaltyPoint = customer.LoyaltyPoint;
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }


        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            return aCustomer;
        }

        public bool Delete(Customer customer)
        {
            int isExecuted = 0;
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);

            db.Customers.Remove(aCustomer);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool Show(Customer customer)
        {
            throw new NotImplementedException();
        }


    }
}
