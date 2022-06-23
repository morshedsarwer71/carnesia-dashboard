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
        public List<BinInscanProductDTO> Products { get; set; }
    }

    public class BinInscanProductDTO
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public string? url { get; set; }
        public string? binName { get; set; }
        public int inputQty { get; set; }
        public int bin { get; set; }
    }
}
