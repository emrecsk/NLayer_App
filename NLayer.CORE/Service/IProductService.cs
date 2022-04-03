using NLayer.CORE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE.Service
{
    public interface IProductService : IService<Products>
    {
        Task<CustomResponseDTO<List<ProductWithCategoryDto>>> ProductsWithCategory();
    }
}
