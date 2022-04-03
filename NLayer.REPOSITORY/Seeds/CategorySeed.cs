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
    internal class CategorySeed : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasData(
                new Categories { Id = 1, Name ="Pencils", CreatedDate = DateTime.Now },
                new Categories { Id = 2, Name = "Notebooks", CreatedDate = DateTime.Now},
                new Categories { Id = 3, Name = "Books", CreatedDate= DateTime.Now}
                );
        }
    }
}
