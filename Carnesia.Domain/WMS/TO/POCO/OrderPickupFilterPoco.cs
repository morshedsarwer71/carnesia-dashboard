using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class OrderPickupFilterPoco
    {
        public string SearchOrder { get; set; }
        public string Outlet { get; set; }
        public string ItemCode { get; set; }
    }
}
