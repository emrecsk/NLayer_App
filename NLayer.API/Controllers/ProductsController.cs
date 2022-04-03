using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.CORE;
using NLayer.CORE.DTOs;
using NLayer.CORE.Service;

namespace NLayer.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;        
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper, IService<Products> service, IProductService productService)
        {
            _mapper = mapper;            
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _productService.GetAllAsync();

            var productsDTO = _mapper.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult(CustomResponseDTO<List<ProductDto>>.Success(200, productsDTO));
        }

        [HttpGet("[action]")]

        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _productService.ProductsWithCategory());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            var productDTO = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDTO<ProductDto>.Success(200, productDTO));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto dtoProduct)
        {
            var productsave = await _productService.AddAsync(_mapper.Map<Products>(dtoProduct));
            var productDTO = _mapper.Map<ProductDto>(productsave);
            return CreateActionResult(CustomResponseDTO<ProductDto>.Success(201, productDTO));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto dtoProduct)
        {
            await _productService.UpdateAsync(_mapper.Map<Products>(dtoProduct));
            return CreateActionResult(CustomResponseDTO<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(product);

            return CreateActionResult(CustomResponseDTO<NoContentDto>.Success(204));
        }

    }
}
