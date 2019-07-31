using BusinessManagementApp.BLL.Manager;
using BusinessManagementApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessManagementApp.Controllers
{
    public class CatalogController : Controller
    {
        CatalogManager _catalogManager = new CatalogManager();
        Catalog _catalog = new Catalog();

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                if (_catalogManager.Add(catalog))
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
            _catalog.Id = Convert.ToInt32(Id);
            var strudent = _catalogManager.GetByID(_catalog);
            return View(strudent);
        }

        [HttpPost]
        public ActionResult Edit(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                if (_catalogManager.Update(catalog))
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

            return View(catalog);
        }

        [HttpGet]

        public ActionResult Delete(int? id)
        {
            _catalog.Id = Convert.ToInt32(id);
            var strudent = _catalogManager.GetByID(_catalog);
            return View(strudent);
        }

        [HttpPost]
        public ActionResult Delete(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                if (_catalogManager.Delete(catalog))
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

            return View(catalog);
        }


        [HttpGet]

        public ActionResult Show()
        {
            _catalog.Catalogs = _catalogManager.GetAll();
            return View(_catalog);
        }

        [HttpPost]

        public ActionResult Show(Catalog catalog)
        {
            var catalogs = _catalogManager.GetAll();
            if (catalog.Code != null)
            {
                catalogs = catalogs.Where(c => c.Code.ToLower().Contains(catalog.Code.ToLower())).ToList();
            }

            if (catalog.Name != null)
            {
                catalogs = catalogs.Where(c => c.Name.ToLower().Contains(catalog.Name.ToLower())).ToList();
            }

            catalog.Catalogs = catalogs;
            return View(catalog);
        }
    }
}