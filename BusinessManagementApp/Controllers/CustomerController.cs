using BusinessManagementApp.BLL.Manager;
using BusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessManagementApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();

        Customer _customer = new Customer();

        public ActionResult Add(Customer customer)
        {
            _customer.Code = customer.Code;
            _customer.Name = customer.Name;
            _customer.Address = customer.Address;
            _customer.Email = customer.Email;
            _customer.ContactNo = customer.ContactNo;
            _customer.LoyaltyPoint = customer.LoyaltyPoint;
            _customerManager.Add(_customer);

            return View();
        }

        public ActionResult Edit(Customer customer)
        {
            _customer.Id = customer.Id;

            Customer aCustomer = _customerManager.GetById(_customer);

            if (aCustomer != null)
            {
                _customer.Code = customer.Code;
                _customer.Name = customer.Name;
                _customer.Address = customer.Address;
                _customer.Email = customer.Email;
                _customer.ContactNo = customer.ContactNo;
                _customer.LoyaltyPoint = customer.LoyaltyPoint;
                _customerManager.Edit(_customer);
            }

            return View();
        }

        public ActionResult Delete(Customer customer)
        {
            _customer.Id = customer.Id;
            _customerManager.Delete(customer);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }


    }
}