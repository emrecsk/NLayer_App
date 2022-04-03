using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Categories>
    {
        Task<Categories> GetCategoryWithProducts(int categoryId);
    }
}
