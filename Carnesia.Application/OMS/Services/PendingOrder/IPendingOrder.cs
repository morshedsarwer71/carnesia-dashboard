using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PendingOrder;
using Carnesia.Domain.OMS.OrderDetails;
using Carnesia.Domain.OMS.OrderTrack;

namespace Carnesia.Application.OMS.Services.PendingOrder
{
    public interface IPendingOrder
    {
        Task<List<PendingOrderDTO>> GetAllPendingOrders();
        Task<List<PendingOrderDTO>> GetAllHoldedOrders();
        Task<List<PendingOrderDTO>> GetPendingOrdersByFilter(PendingOrderFilterDTO filter);
        Task<bool> AssignAgent(AssignAgentDTO agent);
        Task<bool> HoldOrder(HoldOrderDTO orders);
        Task<bool> CancelOrder(int orderId);
        Task<bool> VerifyOrder(int orderId);
        Task<List<AgentDTO>> GetAgents(string stuffType);
        Task<List<PendingOrderDTO>> GetOrderDetails(OrderDetailsFilterDTO filter);
        Task<OrderTrackDTO> GetOrderTrack(string trncode);
    }
}
