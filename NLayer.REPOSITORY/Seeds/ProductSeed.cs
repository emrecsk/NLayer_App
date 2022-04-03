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
    internal class ProductSeed : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(
                new Products { 
                    Id = 1, 
                    Name ="Pencil 1", 
                    CategoriesId = 1, 
                    Price=143, 
                    Stock=520, 
                    CreatedDate =DateTime.Now },
                
                new Products {
                    Id = 2,
                    Name = "Pencil 2",
                    CategoriesId = 1,
                    Price = 345,
                    Stock = 127,
                    CreatedDate = DateTime.Now
                },
                
                new Products {
                    Id = 3,
                    Name = "Pencil 3",
                    CategoriesId = 1,
                    Price = 52,
                    Stock = 1000,
                    CreatedDate = DateTime.Now
                },
                new Products
                {
                    Id = 4,
                    Name = "Notebook 1",
                    CategoriesId = 2,
                    Price = 69,
                    Stock = 142,
                    CreatedDate = DateTime.Now
                },
                new Products
                {
                    Id = 5,
                    Name = "Notebook 2",
                    CategoriesId = 2,
                    Price = 48,
                    Stock = 326,
                    CreatedDate = DateTime.Now
                },
                new Products
                {
                    Id = 6,
                    Name = "Notebook 3",
                    CategoriesId = 2,
                    Price = 140,
                    Stock = 399,
                    CreatedDate = DateTime.Now
                },
                new Products
                {
                    Id = 7,
                    Name = "Book 1",
                    CategoriesId = 3,
                    Price = 115,
                    Stock = 550,
                    CreatedDate = DateTime.Now
                },
                new Products
                {
                    Id = 8,
                    Name = "Book 2",
                    CategoriesId = 3,
                    Price = 265,
                    Stock = 50,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
