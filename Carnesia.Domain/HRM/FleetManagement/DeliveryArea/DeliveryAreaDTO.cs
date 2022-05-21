using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.FleetManagement.DeliveryArea
{
    public class DeliveryAreaDTO
    {
        public string Division { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public string Zone { get; set; }
        public int ZoneNumber { get; set; }
        public string Section { get; set; }
    }
}
