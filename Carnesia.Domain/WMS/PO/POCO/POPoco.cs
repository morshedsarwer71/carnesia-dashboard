using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POPoco
    {
        public string SKU { get; set; }
        public int QTY { get; set; } = 1;
        public decimal LiftingPrice { get; set; } = 1;
            
    }
}
