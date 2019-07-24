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

        public ActionResult Add()
        {
            //_catalog.Id = 1;
            _catalog.Name = "B";
            _catalogManager.Add(_catalog);
            return View();
        }

        public ActionResult Edit()
        {
            _catalog.Id = 3;
            _catalog.Name = "C";
            _catalogManager.Edit(_catalog);
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

    }
}