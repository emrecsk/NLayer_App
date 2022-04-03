using Microsoft.EntityFrameworkCore;
using NLayer.CORE;
using NLayer.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.REPOSITORY.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Products>> GetProductsWithCategory()
        {
            return await _context.Products.Include(x => x.category).ToListAsync();
        }
    }
}
