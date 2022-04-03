using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE.Repositories
{
    public interface IProductRepository : IGenericRepository<Products>
    {
        Task<List<Products>> GetProductsWithCategory();
    }
}
