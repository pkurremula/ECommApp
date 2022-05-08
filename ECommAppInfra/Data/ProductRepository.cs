using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommAppCore.Entities;
using ECommAppCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommAppInfra.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        async Task<Product> IProductRepository.GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        async Task<IReadOnlyList<Product>> IProductRepository.GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
