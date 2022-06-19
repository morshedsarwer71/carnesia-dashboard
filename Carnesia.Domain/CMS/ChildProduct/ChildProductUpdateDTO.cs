using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class ChildProductUpdateDTO
    {
        public SingleChildProductDTO updateProductDTO { get; set; }
        public List<FreeProductDTO> updateFreeProducts { get; set; }
        public List<ProductCategoryDTO> updateProdCategories { get; set; }
    }
}
