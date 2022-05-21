using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Report.AllOrders
{
    public class DetailsDTO
    {
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string Status { get; set; }
        public int QTY { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
}
