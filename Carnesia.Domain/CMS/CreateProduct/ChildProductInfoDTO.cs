using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateProduct
{
    public class ChildProductInfoDTO
    {
        public string productName { get; set; }
        public string productsku { get; set; }
        public int productParentId { get; set; }
        public string weight { get; set; }
        public string productDimension { get; set; }
        public bool isPublish { get; set; }
        public bool isHasFreeProd { get; set; }
        public int productPoints { get; set; }
        public string description { get; set; }
        public bool isColourCodeOrSize { get; set; }
        public string colorCode { get; set; }
        public string sizeOrQty { get; set; }
        public string colorName { get; set; }
        public string metaTitle { get; set; }
        public string metaTags { get; set; }
        public string seachTags { get; set; }
        public string metaDescription { get; set; }
        public decimal vatAmount { get; set; }
        public decimal mrp { get; set; }
        public decimal salesPrice { get; set; }
        public string upSells { get; set; }
        public string crossSells { get; set; }
    }
}
