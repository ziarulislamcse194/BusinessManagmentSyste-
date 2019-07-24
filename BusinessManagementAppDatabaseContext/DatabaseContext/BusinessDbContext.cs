using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementApp.Models.Models;

namespace BusinessManagementAppDatabaseContext.DatabaseContext
{
    public class BusinessDbContext: DbContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
    }
}
