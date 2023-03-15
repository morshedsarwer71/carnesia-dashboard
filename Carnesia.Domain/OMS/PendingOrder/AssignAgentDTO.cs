using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class AssignAgentDTO
    {
        public string agentId { get; set; }
        public List<OrderIdsDTO> orders { get; set; }
    }

    public class HoldOrderDTO
    {
        public string reasone { get; set; }
        public List<OrderIdsDTO> orders { get; set; }
    }
    public class OrderIdsDTO
    {
        public int orderId { get; set; }
    }
}
