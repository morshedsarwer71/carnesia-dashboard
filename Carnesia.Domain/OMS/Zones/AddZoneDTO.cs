using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Zones
{
    public class AddZoneDTO
    {
        public int districtId { get; set; }
        public string zoneName { get; set; }
        public decimal regularPrice { get; set; }
        public int regularDeliveryDay { get; set; }
        public decimal expressPrice { get; set; }
        public int expressDeliveryDay { get; set; }
    }
}
