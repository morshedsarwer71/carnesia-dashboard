using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.FleetManagement.DeliveryCharges
{
    public class DeliveryChargesDTO
    {
        public string Section { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryCharge { get; set; }
    }
}
