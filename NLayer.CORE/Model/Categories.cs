using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CORE
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Products> Products { get; set; } //navigation property
    }
}
