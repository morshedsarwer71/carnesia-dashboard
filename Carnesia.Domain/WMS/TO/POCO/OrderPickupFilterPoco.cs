using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupFilterPoco
    {
        public string orderId { get; set; }
        public string outlet { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
    }
}
