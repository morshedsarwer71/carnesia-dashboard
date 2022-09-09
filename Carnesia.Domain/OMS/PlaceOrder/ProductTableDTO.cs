using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PlaceOrder
{
    public class ProductTableDTO
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string sku { get; set; }
        public bool isCampaign { get; set; }
        public bool isCombo { get; set; } = false;
        public int campaignId { get; set; }
        public int comboId { get; set; }
        public int stock { get; set; }
        public int quantity { get; set; }
        public int productQuantity { get; set; }
        public bool isPercent { get; set; }
        public decimal mrp { get; set; }
        public decimal discount { get; set; }
        public decimal salesPrice { get; set; }
        public decimal productPrice { get; set; }
        public string name { get; set; }
    }
}
