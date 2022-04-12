using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POListViewDetailsPoco
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int QTY { get; set; }
        public decimal LiftingPrice { get; set; }
    }
}
