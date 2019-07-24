using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double ReorderLevel { get; set; }
        public string Description { get; set; }

        public string CatalogName { get; set; }
        public Catalog Catalog { get; set; }
    }
}
