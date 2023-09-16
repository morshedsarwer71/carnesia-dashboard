using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupTablePoco
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public string outlets { get; set; }
        public int quantity { get; set; }
        public string[] orderIds { get; set; }
        public bool ShowDetails { get; set; }
        public IList<OrderPickupDetailsTablePoco> details { get; set; }
    }
}
