using Microsoft.EntityFrameworkCore;
using NLayer.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.REPOSITORY
{
    public class AppDbContext :DbContext
    {
        //program.cs dosyasında veritabanı yolunu verebilmek için aşağıdaki yapıyı oluşturduk ve DbContextOptions kullandık.
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        //her bir entity için dbset oluşturuyoruz.
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductFeature> productFeatures { get; set; }//bunu oluşturmamamız daha iyi çünkü bir ürün var ise ürünün özellikleri olabilir. Aksi halde yalnız başına bu tabloyu kullanamayız. Şimdilik açık bırakıyorum.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //conf. dosyalarını efcore'a bu satır ile bildiriyoruz. Hepsini tek tek tanımlamak yerine çalıştığımız yerdeki dosyaları al dedik.
            base.OnModelCreating(modelBuilder);
        }
    }
}
