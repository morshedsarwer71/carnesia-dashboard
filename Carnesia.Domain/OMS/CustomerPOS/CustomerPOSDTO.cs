using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.CustomerPOS
{
    public class CustomerPOSDTO
    {
        public string NameSKU { get; set; }
        public int QTY { get; set; }
        public decimal MRP { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
