using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class ProductPOCO
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int QTY { get; set; }
        public decimal LiftingPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
