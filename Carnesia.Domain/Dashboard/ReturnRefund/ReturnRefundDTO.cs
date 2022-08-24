using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.ReturnRefund
{
    public class ReturnRefundDTO
    {
        public int received { get; set; }
        public decimal receivedAmount { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int soldQty { get; set; }
        public string? imageUrl { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal returnPrice { get; set; }
    }
}
