using BusinessManagementApp.Models.Models;
using BusinessManagementApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.BLL.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool Edit(Customer customer)
        {
            return _customerRepository.Edit(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(Customer customer)
        {
            return _customerRepository.GetById(customer);
        }

        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }

    }
}
