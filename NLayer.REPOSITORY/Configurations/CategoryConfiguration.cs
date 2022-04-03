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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(c => c.Id); //categories tablosu için key'i burada tanımlıyoruz. Fakat zaten ef core syntax'ine uygun yazdığımız için bunu yapmamıza gerek yoktu. Yalnızca göstermek için yazıyoruz.
            builder.Property(c=>c.Id).UseIdentityColumn();//bu id değerinin birer birer otomatik artması için 
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("Categories");
        }
    }
}
