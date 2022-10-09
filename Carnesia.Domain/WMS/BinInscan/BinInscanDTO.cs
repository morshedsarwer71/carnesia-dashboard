using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinInscan
{
    public class BinInscanDTO
    {
        public string message { get; set; }
        public BinInscanProductDTO Product { get; set; }
    }

    public class BinInscansPoco
    {
        public string message { get; set; }
        public List<BinInscanProductDTO>? Products { get; set; }
    }

    public class BinInscanProductDTO
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public string? url { get; set; }
        public string? binName { get; set; }
        public int inputQty { get; set; }
        public int bin { get; set; }
    }
    
    public class BinDetailsPoco
    {
        public string binName { get; set; }
        public int totalQty { get; set; }
        public List<BinProductDetails> binDetails { get; set; }
    }
    public class BinProductDetails
    {
        public string? sku { get; set; }
        public string ProductCode { get; set; }
        public string productName { get; set; }
        public int binSKUStockQty { get; set; }
        public int physicalQty { get; set; }
        public int availableQty { get; set; }
        public string binName { get; set; }
        public string? expDate { get; set; }
    }
}
