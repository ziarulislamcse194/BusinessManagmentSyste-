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

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                if (_productManager.Add(product))
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
            _product.Id = Convert.ToInt32(Id);
            var product = _productManager.GetByID(_product);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (_productManager.Update(product))
                {
                    ViewBag.SuccesMsg = "Updated";
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

            return View(product);
        }

        [HttpGet]

        public ActionResult Delete(int? id)
        {
            _product.Id = Convert.ToInt32(id);
            var product = _productManager.GetByID(_product);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (ModelState.IsValid)
            {
                if (_productManager.Delete(product))
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

            return View(product);
        }


        [HttpGet]

        public ActionResult Show()
        {
            _product.Products = _productManager.GetAll();
            return View(_product);
        }

        [HttpPost]

        public ActionResult Show(Product product)
        {
            var products = _productManager.GetAll();
            if (product.Code != null)
            {
                products = products.Where(c => c.Code.ToLower().Contains(product.Code.ToLower())).ToList();
            }

            if (product.Name != null)
            {
                products = products.Where(c => c.Name.ToLower().Contains(product.Name.ToLower())).ToList();
            }

            if (product.Catagory != null)
            {
                products = products.Where(c => c.Catagory.ToLower().Contains(product.Catagory.ToLower())).ToList();
            }

            if (product.ReorderLevel>0)
            {
                products = products.Where(c => c.ReorderLevel == product.ReorderLevel).ToList();
            }

            if (product.Description != null)
            {
                products = products.Where(c => c.Description.ToLower().Contains(product.Description.ToLower())).ToList();
            }


            product.Products = products;
            return View(product);
        }

    }
}