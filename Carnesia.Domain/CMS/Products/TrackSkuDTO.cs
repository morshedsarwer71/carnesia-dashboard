using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Products
{
    public class TrackSkuDTO
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string sku { get; set; }
        public string image { get; set; }
        public decimal mrp { get; set; }
        public decimal salesPrice { get; set; }
        public decimal discount { get; set; }
        public bool isCampaign { get; set; }
        public int campaignStock { get; set; }
        public int physicalStock { get; set; }
        public int virtualStock { get; set; }
    }
}
