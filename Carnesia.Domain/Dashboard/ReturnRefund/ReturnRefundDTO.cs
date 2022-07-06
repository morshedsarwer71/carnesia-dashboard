using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.ReturnRefund
{
    public class ReturnRefundDTO
    {
        public string productCode { get; set; }
        public string sku { get; set; }
        public string ProductName { get; set; }
        public string imageURL { get; set; }
        public int soldQTY { get; set; }
        public int received { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal receivedAmount { get; set; }
    }
}
