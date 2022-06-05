using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class ChildProductDTO
    {
        public ChildProductDetailsDTO productDTO { get; set; }
        public List<FreeProductDTO> freeProducts { get; set; }
        public List<ProductCategoryDTO> prodCategories { get; set; }
        public List<ProductImageDTO> images { get; set; }
    }
}
