﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ProductList
{
    public class ProductQuickSettingDTO
    {
        public int productId { get; set; }
        public int productPriceId { get; set; }
        public string productName { get; set; }
        public string productsku { get; set; }
        public string productCode { get; set; }
        public decimal mrp { get; set; }
        public decimal newMRP { get; set; }
        public decimal discount { get; set; }
        public bool isPercent { get; set; }
        public bool isPublish { get; set; }
        public bool isNewArrival { get; set; }
        public bool isApproved { get; set; }
    }
}
