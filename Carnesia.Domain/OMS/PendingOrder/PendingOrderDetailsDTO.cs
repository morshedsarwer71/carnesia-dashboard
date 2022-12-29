using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class PendingOrderDetailsDTO
    {
        public decimal total { get; set; }
        public decimal grandTotal { get; set; }
        public decimal discount { get; set; }
        public decimal shippingPrice { get; set; }
        public bool ShowDetails { get; set; }
        public List<PendingOrderProductsDTO> orderProducts { get; set; }
        public List<PendingOrderProductsDTO> orderCombos { get; set; }
    }
}
