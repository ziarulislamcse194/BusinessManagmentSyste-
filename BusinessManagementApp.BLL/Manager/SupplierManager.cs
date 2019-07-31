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
        public bool Delete(Supplier supplier)
        {
            return _supplierRepository.Delete(supplier);
        }
        public bool Update(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }

        public bool Show(Supplier supplier)
        {
            return _supplierRepository.Show(supplier);
        }
        public List<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }
        public Supplier GetByID(Supplier supplier)
        {
            return _supplierRepository.GetByID(supplier);
        }

    }
}
