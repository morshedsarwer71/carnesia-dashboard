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
		Task<string> CommitReturn(string orderId);
		Task<List<PendingReturnDTO>> GetPendingReturns();
		Task<List<PendingReturnDTO>> GetPendingReturnsByFilter(PendingReturnsFilterDTO filter);
		Task<PickPackDTO> GetComboProducts(string TrnCode, string BcCode);
		Task<PickPackDTO> CheckUID(string TrnCode, string BcCode, string UID);
		Task<bool> SubmitComboReturn(string TrnCode, string BcCode, List<string> uids);
	}
}
