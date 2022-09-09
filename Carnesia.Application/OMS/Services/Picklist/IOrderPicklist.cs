using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.Picklist.CreatePicklist;
using Carnesia.Domain.OMS.PendingOrder;

namespace Carnesia.Application.OMS.Services.Picklist
{
    public interface IOrderPicklist
    {
        Task<List<PendingOrderDTO>> GetOrders();
        Task<List<PendingOrderDTO>> GetOrdersByFilter(PicklistFilterDTO filter);
    }
}
