using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.OutScan
{
    public class OutScanDTO
    {
        public string message { get; set; }
        public OutScanProductDTO? data { get; set; }
    }
    public class OutScanProductDTO
    {
        public string sku { get; set; }
        public string? picCode { get; set; }
        public string? binName { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int sourceStock { get; set; }
        public int destinationStock { get; set; }
        public int qty { get; set; }
        public int Rqty { get; set; }
    }
}
