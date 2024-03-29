﻿using System;
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
        public int productId { get; set; }
        public int parentId { get; set; }
    }

    public class ProductListFilterV2DTO
    {
        public int brandId { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
    }
}
