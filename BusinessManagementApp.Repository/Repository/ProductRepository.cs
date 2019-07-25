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
            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.Id == product.Id);
            int isExecuted = 0;

            if (aProduct != null)
            {
                aProduct.Code = product.Code;
                aProduct.Name = product.Name;
                aProduct.Catagory = product.Catagory;
                aProduct.ReorderLevel = product.ReorderLevel;
                aProduct.Description = product.Description;
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.Id == product.Id);
            return aProduct;
        }

        public bool Delete(Product product)
        {
            int isExecuted = 0;
            Product aProduct = db.Products.FirstOrDefault(c => c.Id == product.Id);

            db.Products.Remove(aProduct);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }

    }
}
