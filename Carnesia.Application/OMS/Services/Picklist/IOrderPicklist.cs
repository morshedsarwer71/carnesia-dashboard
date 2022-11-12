using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.Picklist.CreatePicklist;
using Carnesia.Domain.OMS.PendingOrder;
using Carnesia.Domain.OMS.Picklist.CreatePicklist;
using Carnesia.Domain.OMS.PickPack;
using Carnesia.Domain.OMS.Picklist.GeneratedPicklist;

namespace Carnesia.Application.OMS.Services.Picklist
{
    public interface IOrderPicklist
    {
        Task<List<PendingOrderDTO>> GetOrders();
        Task<List<PendingOrderDTO>> GetOrdersByFilter(PicklistFilterDTO filter);
        Task<bool> GeneratePicklist(List<PickListGenerateDTO> orderIDS);
        Task<List<GeneratedPicklistDTO>> GetGeneratedPiclist();
        Task<PickPackDTO> RemoveOrderFromPicklist(RemoveFromPicklistDTO order);
        Task<PickPackDTO> ConfirmPicklist(string pickCode);
    }
}
