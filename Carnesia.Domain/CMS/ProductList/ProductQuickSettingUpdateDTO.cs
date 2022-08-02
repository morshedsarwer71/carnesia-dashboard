using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ProductList
{
    public class ProductQuickSettingUpdateDTO
    {
        public int productId { get; set; }
        public decimal mrp { get; set; }
        public decimal discount { get; set; }
        public bool isPercent { get; set; }
        public bool isPublish { get; set; }
        public bool isNewArrival { get; set; }
    }
}
