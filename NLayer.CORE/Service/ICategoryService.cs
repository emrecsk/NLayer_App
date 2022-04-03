using NLayer.CORE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE.Service
{
    public interface ICategoryService : IService<Categories>
    {
        public Task<CustomResponseDTO<CategoryWithProducts>> GetCategoryWithProducts(int categoryId);
    }
}
