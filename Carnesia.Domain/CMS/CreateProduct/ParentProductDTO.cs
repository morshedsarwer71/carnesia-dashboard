using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateProduct
{
    public class ParentProductDTO
    {
        public string? name { get; set; }
        public int brandId { get; set; }
        public string brandName { get; set; }
        public string originId { get; set; }
        public string productType { get; set; } = "Compound";
        public string description { get; set; }
    }
}
