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

            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool Edit(Catalog catalog)
        {
            Catalog aCatalog = db.Catalogs.FirstOrDefault(c => c.Id == catalog.Id);
            int isExecuted = 0;

            if (aCatalog != null)
            {
                aCatalog.Code = catalog.Code;
                aCatalog.Name = catalog.Name;
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Catalog catalog)
        {
            int isExecuted = 0;
            Catalog aCatalog = db.Catalogs.FirstOrDefault(c => c.Id == catalog.Id);

            db.Catalogs.Remove(aCatalog);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public List<Catalog> GetAll()
        {
            return db.Catalogs.ToList();
        }

        public Catalog GetById(Catalog catalog)
        {
            Catalog aCatalog = db.Catalogs.FirstOrDefault(c => c.Id == catalog.Id);
            return aCatalog;
        }

    }
}
