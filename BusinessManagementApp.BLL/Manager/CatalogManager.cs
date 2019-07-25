using BusinessManagementApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementApp.Models.Models;

namespace BusinessManagementApp.BLL.Manager
{
    public class CatalogManager
    {
        CatalogRepository _catalogRepository = new CatalogRepository();

        public bool Add(Catalog catalog)
        {
            return _catalogRepository.Add(catalog);
        }


        public bool Edit(Catalog catalog)
        {
            return _catalogRepository.Edit(catalog);
        }

        public bool Delete(Catalog catalog)
        {
            return _catalogRepository.Delete(catalog);
        }

        public List<Catalog> GetAll()
        {
            return _catalogRepository.GetAll();
        }

        public Catalog GetById(Catalog catalog)
        {
            return _catalogRepository.GetById(catalog);
        }


    }
}
