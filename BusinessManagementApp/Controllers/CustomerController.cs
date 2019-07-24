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

        public ActionResult Add()
        {
            _customer.Code = "001";
            _customer.Name = "A";
            _customer.Address = "Dhaka";
            _customer.Email = "zia@gmail.com";
            _customer.ContactNo = 01774621935;
            _customer.LoyaltyPoint = 1000;
            _customerManager.Add(_customer);

            return View();
        }

        public ActionResult Edit()
        {
            _customer.Id = 1;
            _customer.Code = "001";
            _customer.Name = "B";
            _customer.Address = "Dhaka";
            _customer.Email = "zia@gmail.com";
            _customer.ContactNo = 01774621935;
            _customer.LoyaltyPoint = 1000;
            _customerManager.Edit(_customer);

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}