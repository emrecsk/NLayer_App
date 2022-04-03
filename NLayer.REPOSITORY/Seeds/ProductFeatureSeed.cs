using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.REPOSITORY.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature { 
                Id = 1,
                Color = "Red",
                height = 8,
                width = 3,
                ProductId = 1,
            },
            new ProductFeature { 
                Id = 2, 
                Color = "Purple", 
                height = 25, 
                width = 15,
                ProductId = 4,
            }
            );
        }
    }
}
