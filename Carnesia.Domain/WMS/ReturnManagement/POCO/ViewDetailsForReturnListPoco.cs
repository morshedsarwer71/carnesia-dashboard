using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReturnManagement.POCO
{
    public class ViewDetailsForReturnListPoco
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int QTY { get; set; }
        public int LiftingPrice { get; set; }
        public int TotalCost { get; set; }
    }
}
