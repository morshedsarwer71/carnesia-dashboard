using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupDetailsTablePoco
    {
        public string outlet { get; set; }
        public int stock { get; set; }
        public int requestQTY { get; set; }
    }
}
