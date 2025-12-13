using CleanArchitecture.application.DTO;
using CleanArchitecture.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.IRepository
{
    public interface IproductRepository
    {
        //Task<Product> GetListProdducts();

        Task<Product> GetProduct(int productId);

        Task<Product> AddProduct(Product p);

      
    }
}
