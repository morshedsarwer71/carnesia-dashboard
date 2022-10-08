using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PickPack;
using Carnesia.Domain.OMS.ReturnManagement.PendingReturn;

namespace Carnesia.Application.OMS.Services.ReceiveReturn
{
	public interface IReceiveReturn
	{
		Task<PickPackDTO> GetOrderDetails(string orderId);
		Task<PickPackDTO> ReturnItem(string orderId, string uid, bool returnType);
		Task<List<PendingReturnDTO>> GetPendingReturns();
		Task<List<PendingReturnDTO>> GetPendingReturnsByFilter(PendingReturnsFilterDTO filter);
	}
}
