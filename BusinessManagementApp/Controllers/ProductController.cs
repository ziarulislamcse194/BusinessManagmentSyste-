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

        public ActionResult Add(Product product)
        {
            _product.Code = product.Code;
            _product.Name = product.Name;
            _product.Catagory = product.Catagory;
            _product.ReorderLevel = product.ReorderLevel;
            _product.Description = product.Description;
            _productManager.Add(_product);
            return View();
        }

        public ActionResult Edit(Product product)
        {
            _product.Id = product.Id;

            Product aProduct = _productManager.GetById(_product);

            if (aProduct != null)
            {
                _product.Code = product.Code;
                _product.Name = product.Name;
                _product.Catagory = product.Catagory;
                _product.ReorderLevel = product.ReorderLevel;
                _product.Description = product.Description;
                _productManager.Edit(_product);
            }

            
            return View();
        }

        public ActionResult Delete(Product product)
        {
            _product.Id = product.Id;
            _productManager.Delete(product);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }



    }
}