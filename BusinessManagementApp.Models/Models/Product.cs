using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Models.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50, MinimumLength = 2)]

        public string Code { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public double ReorderLevel { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }
    }
}
