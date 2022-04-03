using AutoMapper;
using NLayer.CORE;
using NLayer.CORE.DTOs;
using NLayer.CORE.Repositories;
using NLayer.CORE.Service;
using NLayer.CORE.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.SERVICE.Services
{
    public class ProductService : Service<Products>, IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductService(IUnitofWork unitofWork, IGenericRepository<Products> repository, IProductRepository productRepository, IMapper mapper) : base(unitofWork, repository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDTO<List<ProductWithCategoryDto>>> ProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var dto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDTO<List<ProductWithCategoryDto>>.Success(200, dto);
        }
    }
}
