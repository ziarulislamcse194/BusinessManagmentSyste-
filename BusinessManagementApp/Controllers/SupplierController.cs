using BusinessManagementApp.BLL.Manager;
using BusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessManagementApp.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager = new SupplierManager();

        Supplier _supplier = new Supplier();


        public ActionResult Add()
        {
            _supplier.Code = "001";
            _supplier.Name = "A";
            _supplier.Address = "Dhaka";
            _supplier.Email = "zia@gmail.com";
            _supplier.Contact = 01774621935;
            _supplier.ContactPerson = "Sultan";
            _supplierManager.Add(_supplier);

            return View();
        }

        public ActionResult Edit()
        {
            _supplier.Id = 1;
            _supplier.Code = "001";
            _supplier.Name = "AB";
            _supplier.Address = "Dhaka";
            _supplier.Email = "zia@gmail.com";
            _supplier.Contact = 01774621935;
            _supplier.ContactPerson = "Sultan";
            _supplierManager.Add(_supplier);

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}