using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ProductList
{
    public class ProductListV2DTO
    {
        public string productName { get; set; }
        public string parentName { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productTy { get; set; }
        public string origin { get; set; }
        public decimal mrp { get; set; }
        public decimal discount { get; set; }
        public string discountType { get; set; }
        public decimal salesPrice { get; set; }
        public string brand { get; set; }
        public string updatedBy { get; set; }
        public string createdBy { get; set; }
        public int productId { get; set; }
        public int parentId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool isPublish { get; set; }
        public string parentCat { get; set; }
        public string childCat { get; set; }
        public string grandChildCat { get; set; }
    }

    public class ProductListFilterV2DTO
    {
        public int brandId { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public bool isPublish { get; set; } = true;
    }
}
