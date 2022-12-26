using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class PendingOrderProductsDTO
    {
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public decimal mrp { get; set; }
        public int quantity { get; set; }
        public decimal totalMrp { get; set; }
        public bool showComboProducts { get; set; }
        public bool isCombo { get; set; }
        public List<OrdersBogoCombosProducts> combosProducts { get; set; }
    }

    public class OrdersBogoCombosProducts
    {
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
    }
}
