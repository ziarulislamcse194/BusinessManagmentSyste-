using BusinessManagementApp.Models.Models;
using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Repository.Repository
{
    public class CatalogRepository
    {
        BusinessDbContext db = new BusinessDbContext();

        public bool Add(Catalog catalog)
        {
            db.Catalogs.Add(catalog);

            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Catalog catalog)
        {
            Catalog aCatalog = db.Catalogs.FirstOrDefault(c => c.Id == catalog.Id);
            int saved = 0;

            if (aCatalog != null)
            {
                aCatalog.Name = catalog.Name;
                saved = db.SaveChanges();
            }

            if (saved > 0)
            {
                return true;
            }

            return false;
        }



    }
}
