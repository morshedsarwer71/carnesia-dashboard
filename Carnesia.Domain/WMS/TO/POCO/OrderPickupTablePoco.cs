using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupTablePoco
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Outlets { get; set; }
        public int Quantity { get; set; }
        public string[] OrderIds { get; set; }
    }
}
