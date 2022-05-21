using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.OMS.OpenRun
{
    public class DetailsDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int QTY { get; set; }
        public int DeliveryQTY { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
