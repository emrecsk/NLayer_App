using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}
