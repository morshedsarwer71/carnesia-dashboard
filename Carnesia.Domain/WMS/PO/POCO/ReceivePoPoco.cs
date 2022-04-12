using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class ReceivePoPoco
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int PoQTY { get; set; }
        public int QCPassed { get; set; }
        public decimal LiftingPrice { get; set; }
        public int QCFailed { get; set; }
        public int NotArrived { get; set; }
    }
}
