using BusinessManagementApp.Models.Models;
using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            int isExecuted = 0;

            db.Catalogs.Add(catalog);
            isExecuted = db.SaveChanges();

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

        public bool Update(Catalog catalog)
        {
            int isExecuted = 0;
            //Method 1
            //Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (aStudent != null)
            //{
            //    aStudent.Name = student.Name;
            //    isExecuted = db.SaveChanges();
            //}

            //Method 2
            db.Entry(catalog).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Show(Catalog catalog)
        {
            throw new NotImplementedException();
        }
        public List<Catalog> GetAll()
        {
            return db.Catalogs.ToList();
        }
        public Catalog GetByID(Catalog catalog)
        {
            Catalog aCatalog = db.Catalogs.FirstOrDefault(c => c.Id == catalog.Id);
            return aCatalog;
        }

    }
}
