using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillUIDDataDTO
    {
        public string? nameAndSKU { get; set; }
        public decimal mrp { get; set; }
        public string? productCode { get; set; }
        public string? error { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public int quantity { get; set; }
    }

    public class GenerateBillUIDCollectionDTO
    {
        public string uid { get; set; }
        public string productCode { get; set; }
    }
}
