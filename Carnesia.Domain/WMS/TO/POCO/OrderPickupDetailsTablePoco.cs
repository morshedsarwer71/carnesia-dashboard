using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupDetailsTablePoco
    {
        public string Outlet { get; set; }
        public int Stock { get; set; }
        public int RequestQTY { get; set; }
    }
}
