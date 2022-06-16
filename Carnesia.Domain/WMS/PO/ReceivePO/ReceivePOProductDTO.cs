using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.ReceivePO
{
    public class ReceivePOProductDTO
    {
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string poCode { get; set; }
        public decimal liftingPrice { get; set; }
        public int quantity { get; set; }
        public int qcPassed { get; set; }
        public int qcFailed { get; set; }
        public int notArrivedQty { get; set; }
        public decimal totalPrice { get; set; }
    }
}
