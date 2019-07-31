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
        public bool Delete(Catalog catalog)
        {
            return _catalogRepository.Delete(catalog);
        }
        public bool Update(Catalog catalog)
        {
            return _catalogRepository.Update(catalog);
        }

        public bool Show(Catalog catalog)
        {
            return _catalogRepository.Show(catalog);
        }
        public List<Catalog> GetAll()
        {
            return _catalogRepository.GetAll();
        }
        public Catalog GetByID(Catalog catalog)
        {
            return _catalogRepository.GetByID(catalog);
        }


    }
}
