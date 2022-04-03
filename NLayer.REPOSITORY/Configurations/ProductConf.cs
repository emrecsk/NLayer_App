using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.REPOSITORY.Configurations
{
    internal class ProductConf : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).UseIdentityColumn();
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c=>c.Stock).IsRequired();
            builder.Property(c=>c.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.ToTable("Products");
            builder.HasOne(c=>c.category).WithMany(c=>c.Products).HasForeignKey(c=>c.CategoriesId);
        }
    }
}
