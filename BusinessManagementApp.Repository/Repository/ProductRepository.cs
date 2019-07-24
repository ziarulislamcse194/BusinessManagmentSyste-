using BusinessManagementApp.Models.Models;
using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Repository.Repository
{
    public class ProductRepository
    {
        BusinessDbContext db = new BusinessDbContext();

        public bool Add(Product product)
        {
            db.Products.Add(product);
            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.Id == product.Id);
            int saved = 0;

            if (aProduct != null)
            {
                aProduct.Name = product.Name;
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
