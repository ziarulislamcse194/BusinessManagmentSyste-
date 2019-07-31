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

        [HttpGet]
        public ActionResult Add()
        {
            return View(_customer);
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (_customerManager.Add(customer))
                {
                    ViewBag.SuccesMsg = "Saved";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailedMsg = "VAlidation Failed";
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            _customer.Id = Convert.ToInt32(Id);
            var customer = _customerManager.GetById(_customer);
            return View(customer);
        }

        [HttpPost]
        
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (_customerManager.Add(customer))
                {
                    ViewBag.SuccesMsg = "Updated";
                }
                else
                {
                    ViewBag.FailedMsg = "Updated Failed";
                }
            }
            else
            {
                ViewBag.FailedMsg = "VAlidation Failed";
            }

            return View(customer);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            _customer.Id = Convert.ToInt32(Id);
            var customer = _customerManager.GetById(_customer);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (_customerManager.Delete(customer))
                {
                    ViewBag.SuccesMsg = "Deleted";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailedMsg = "VAlidation Failed";
            }

            return View(customer);
        }

        [HttpGet]
        public ActionResult Show()
        {
            _customer.Customers = _customerManager.GetAll();
            return View(_customer);
        }

        [HttpPost]
        public ActionResult Show(Customer customer)
        {
            var customers = _customerManager.GetAll();
            if (customer.Code != null)
            {
                customers = customers.Where(c => c.Code.ToLower().Contains(customer.Code.ToLower())).ToList();
            }

            if (customer.Name != null)
            {
                customers = customers.Where(c => c.Name.ToLower().Contains(customer.Name.ToLower())).ToList();
            }

            if (customer.Address != null)
            {
                customers = customers.Where(c => c.Address.ToLower().Contains(customer.Address.ToLower())).ToList();
            }

            if (customer.Email != null)
            {
                customers = customers.Where(c => c.Email.ToLower().Contains(customer.Email.ToLower())).ToList();
            }

            if (customer.ContactNo>0l)
            {
                customers = customers.Where(c => c.ContactNo == customer.ContactNo).ToList();
            }

            if (customer.LoyaltyPoint > 0l)
            {
                customers = customers.Where(c => c.LoyaltyPoint == customer.LoyaltyPoint).ToList();
            }

            customer.Customers = customers;
            return View(customer);
        }
    }
}