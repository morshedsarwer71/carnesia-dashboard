using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PendingOrder;
using Carnesia.Domain.OMS.AssignDelivery.Dispatch;
using Carnesia.Domain.OMS.PickPack;

namespace Carnesia.Application.OMS.Services.Dispatch
{
    public interface IDispatch
    {
        Task<List<PendingOrderDTO>> GetOrders();
        Task<List<PendingOrderDTO>> GetDispatchedOrders();
        Task<List<PendingOrderDTO>> GetOrdersByFilter(DispatchFilterDTO filter);
        Task<bool> AssignCourier(CreateDispatchDTO dispatchData);
        Task<PickPackDTO> ConfirmDispatch(int orderId);
        Task<PickPackDTO> CancelDispatch(int orderId);
    }
}
