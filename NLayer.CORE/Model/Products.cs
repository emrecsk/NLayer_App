using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoriesId { get; set; }
        public Categories category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
