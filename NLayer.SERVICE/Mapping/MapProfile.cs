using AutoMapper;
using NLayer.CORE;
using NLayer.CORE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.SERVICE.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<Categories, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Products>();
            CreateMap<Products, ProductWithCategoryDto>();
            CreateMap<Categories, CategoryWithProducts>();
        }
    }
}
