using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class SingleChildProductDTO
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string productsku { get; set; }
        public string productParentName { get; set; }
        public string brandName { get; set; }
        public int brandId { get; set; }
        public string originId { get; set; }
        public int productParentID { get; set; }
        public int shelfLife { get; set; }
        public decimal weight { get; set; }
        public string productDimension { get; set; }
        public bool isPublish { get; set; }
        public bool isHasFreeProd { get; set; }
        public bool isNewArrival { get; set; }
        public int productPoints { get; set; }
        public string description { get; set; }
        public string richDescription { get; set; }
        public bool isSize { get; set; }
        public string colorCode { get; set; }
        public string sizeOrQty { get; set; }
        public string colorName { get; set; }
        public string metaTitle { get; set; }
        public string metaTags { get; set; }
        public string seachTags { get; set; }
        public string metaDescription { get; set; }
        public decimal? vatAmount { get; set; }
        public decimal mrp { get; set; }
        public string uom { get; set; }
        public bool isPercent { get; set; }
        public decimal discount { get; set; }
        public string upSells { get; set; }
        public string crossSells { get; set; }
        public List<FreeProductDTO> freeProducts { get; set; }
        public List<ProductCategoryDTO> prodCategories { get; set; }
        public List<ProductImageDTO> images { get; set; }
    }
}
