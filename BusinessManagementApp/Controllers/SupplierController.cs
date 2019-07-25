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


        public ActionResult Add(Supplier supplier)
        {
            _supplier.Code = supplier.Code;
            _supplier.Name = supplier.Name;
            _supplier.Address = supplier.Address;
            _supplier.Email = supplier.Email;
            _supplier.Contact = supplier.Contact;
            _supplier.ContactPerson = supplier.ContactPerson;
            _supplierManager.Add(_supplier);

            return View();
        }

        public ActionResult Edit(Supplier supplier)
        {
            _supplier.Id = supplier.Id;

            Supplier aSupplier = _supplierManager.GetById(_supplier);

            if (aSupplier != null)
            {
                _supplier.Code = supplier.Code;
                _supplier.Name = supplier.Name;
                _supplier.Address = supplier.Address;
                _supplier.Email = supplier.Email;
                _supplier.Contact = supplier.Contact;
                _supplier.ContactPerson = supplier.ContactPerson;
                _supplierManager.Edit(_supplier);
            }

            return View();
        }

        public ActionResult Delete(Supplier supplier)
        {
            _supplier.Id = supplier.Id;
            _supplierManager.Delete(supplier);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}