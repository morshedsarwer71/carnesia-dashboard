using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PendingOrder;

namespace Carnesia.Application.OMS.Services.PendingOrder
{
    public interface IPendingOrder
    {
        Task<List<PendingOrderDTO>> GetAllPendingOrders();
        Task<bool> AssignAgent(AssignAgentDTO agent);
    }
}
