using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PendingOrder;
using Carnesia.Domain.OMS.OrderDetails;

namespace Carnesia.Application.OMS.Services.PendingOrder
{
    public interface IPendingOrder
    {
        Task<List<PendingOrderDTO>> GetAllPendingOrders();
        Task<bool> AssignAgent(AssignAgentDTO agent);
        Task<bool> CancelOrder(int orderId);
        Task<bool> VerifyOrder(int orderId);
        Task<List<AgentDTO>> GetAgents();
        Task<List<PendingOrderDTO>> GetOrderDetails(OrderDetailsFilterDTO filter);
    }
}
