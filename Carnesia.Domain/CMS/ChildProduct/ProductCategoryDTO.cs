using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class ProductCategoryDTO
    {
        public int parentCatId { get; set; }
        public string? parentCatName { get; set; }
        public int childCatId { get; set; }
        public string? childCatName { get; set; }
        public int gChildCatId { get; set; }
        public string? gChildCatName { get; set; }
        public string? gChaildCatName { get; set; }
    }
}
