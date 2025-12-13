using CleanArchitecture.application.DTO;
using CleanArchitecture.application.IRepository;
using CleanArchitecture.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence.Repository
{
    public class ProductRepository : IproductRepository
    {
        private readonly Database _db;
        public ProductRepository(Database db) 
        {
            _db = db;   
        }

      
        public async Task<Product> AddProduct(Product p)
        {
            await _db.Product.AddAsync(p);  
            await _db.SaveChangesAsync();    
            return p;                        // Return the tracked entity
        }
        

        public async Task<Product> GetProduct(int productId)
        {
            var p = await _db.Product.Include(p => p.Category).FirstOrDefaultAsync(p => p.ProductId == productId);
            return p ; 
        }

    }
}
