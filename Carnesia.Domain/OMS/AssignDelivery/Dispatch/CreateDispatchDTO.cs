using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.AssignDelivery.Dispatch
{
    public class CreateDispatchDTO
    {
        public int courierId { get; set; }
        public string carrierName { get; set; }
        public string phoneNumber { get; set; }
        public List<DispatchIdCodeDTO> orders { get; set; }
    }

    public class DispatchIdCodeDTO
    {
        public int orderId { get; set; }
    }
}
