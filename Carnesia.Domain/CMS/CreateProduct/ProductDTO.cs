using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateProduct
{
    public class ProductDTO
    {
        public ChildProductInfoDTO productDTO { get; set; }
        public List<FreeProductDTO> freeProducts { get; set; } = new List<FreeProductDTO>();
        public List<ProductCategoryDTO> prodCategories { get; set; }
        public List<ProductImageDTO> images { get; set; }
    }
}
