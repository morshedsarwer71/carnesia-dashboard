using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReturnManagement.POCO
{
    public class ReturnUIDTablePoco
    {
        public int POID { get; set; }
        public int ProductCode { get; set; }
        public int SKU { get; set; }
        public int ReturnQTY { get; set; }
        public decimal LiftingPrice { get; set; }
        public string ProductName { get; set; }
        public string VendorName { get; set; }
    }
}
