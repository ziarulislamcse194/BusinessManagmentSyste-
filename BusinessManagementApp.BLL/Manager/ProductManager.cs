﻿using BusinessManagementApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementApp.Models.Models;

namespace BusinessManagementApp.BLL.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();

        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public bool Edit(Product product)
        {
            return _productRepository.Edit(product);
        }



    }
}
