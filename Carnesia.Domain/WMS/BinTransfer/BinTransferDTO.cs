using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinTransfer
{
    public class BinTransferDTO
    {
        public string message { get; set; }
        public BinTransferProductDTO? product { get; set; }
    }
    public class BinTransferProductDTO
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public string? url { get; set; }
        public string binName { get; set; }
        public string productCode { get; set; }
        public int inputQty { get; set; }
    }
}
