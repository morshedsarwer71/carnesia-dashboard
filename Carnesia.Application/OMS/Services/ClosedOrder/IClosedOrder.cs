using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.ClosedOrder;
using Carnesia.Domain.OMS.PendingOrder;

namespace Carnesia.Application.OMS.Services.ClosedOrder
{
    public interface IClosedOrder
    {
        Task<List<PendingOrderDTO>> GetClosedOrders(ClosedOrderFilterDTO orderFilter);
        Task<bool> AssignAgent(AssignAgentDTO agent);
        Task<bool> TakeFeedBack(CustomerFeedbackDTO feedback);
    }
}
