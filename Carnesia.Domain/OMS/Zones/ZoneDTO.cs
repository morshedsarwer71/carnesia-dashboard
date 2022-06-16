using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Zones
{
    public class ZoneDTO
    {
        public int id { get; set; }
        public string zoneName { get; set; }
        public int districId { get; set; }
        public string districName { get; set; }
        public int divisionId { get; set; }
        public string divisionName { get; set; }
        public decimal regulaPrice { get; set; }
        public int regularDeliveryDay { get; set; }
        public decimal expressPrice { get; set; }
        public int expressDeliDay { get; set; }
    }
}
