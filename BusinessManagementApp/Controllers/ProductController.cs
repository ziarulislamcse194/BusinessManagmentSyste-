using BusinessManagementApp.BLL.Manager;
using BusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessManagementApp.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager();
        Product _product = new Product();

        public ActionResult Add()
        {
            _product.Code = "001";
            _product.Name = "A";
            _product.ReorderLevel = 100;
            _product.Description = "Dhaka 1200";
            _productManager.Add(_product);
            return View();
        }

        public ActionResult Edit()
        {
            _product.Id = 2;
            _product.Code = "001";
            _product.Name = "A";
            _product.ReorderLevel = 100;
            _product.Description = "Dhaka 1200";
            _productManager.Add(_product);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }



    }
}