using BusinessManagementApp.Models.Models;
using BusinessManagementAppDatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog()
            {
                Code = "001",
                Name = "A",
            };

            BusinessDbContext db = new BusinessDbContext();

            db.Catalogs.Add(catalog);
            int rowAffected = db.SaveChanges();
            if (rowAffected > 0)
            {
                Console.WriteLine("Successfully");
            }

            Console.ReadKey();
        }
    }
}
