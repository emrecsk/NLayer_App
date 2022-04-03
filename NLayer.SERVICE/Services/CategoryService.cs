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
    public class CategoryService : Service<Categories>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IUnitofWork unitofWork, IGenericRepository<Categories> repository, ICategoryRepository categoryRepository, IMapper mapper) : base(unitofWork, repository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDTO<CategoryWithProducts>> GetCategoryWithProducts(int categoryId)
        {
            var catwithproduct = await _categoryRepository.GetCategoryWithProducts(categoryId);
            var dto = _mapper.Map<CategoryWithProducts>(catwithproduct);
            return CustomResponseDTO<CategoryWithProducts>.Success(200, dto);
        }
    }
}
