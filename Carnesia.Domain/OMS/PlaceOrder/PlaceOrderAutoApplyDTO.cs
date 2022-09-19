using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PlaceOrder
{
    public class PlaceOrderAutoApplyDTO
    {
        public int id { get; set; }
        public decimal mincartamnt { get; set; }
        public decimal amount { get; set; }
        public bool isDeliveryCharge { get; set; }
    }
}
