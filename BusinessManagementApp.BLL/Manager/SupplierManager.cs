using BusinessManagementApp.Models.Models;
using BusinessManagementApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.BLL.Manager
{

    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();

        public bool Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }

        public bool Edit(Supplier supplier)
        {
            return _supplierRepository.Edit(supplier);
        }


    }
}
