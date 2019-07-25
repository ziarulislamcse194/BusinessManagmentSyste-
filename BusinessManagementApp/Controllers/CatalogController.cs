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

        public ActionResult Add(Catalog catalog)
        {
            _catalog.Code = catalog.Code;
            _catalog.Name = catalog.Name;
            _catalogManager.Add(_catalog);
            return View();
        }

        public ActionResult Edit(Catalog catalog)
        {
            _catalog.Id = catalog.Id;

            Catalog aCatalog = _catalogManager.GetById(_catalog);

            if (aCatalog != null)
            {
                _catalog.Code = catalog.Code;
                _catalog.Name = catalog.Name;
                _catalogManager.Edit(_catalog);
            }
            
            return View();
        }

        public ActionResult Delete(Catalog catalog)
        {
            _catalog.Id = catalog.Id;
            _catalogManager.Delete(_catalog);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

    }
}