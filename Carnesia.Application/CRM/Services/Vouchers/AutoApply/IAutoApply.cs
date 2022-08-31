using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.AutoApply.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.AutoApply.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.AutoApply
{
	public interface IAutoApply
	{
		Task<bool> NewAutoApply(AddAutoApplyDTO autoApply);
		Task<List<AutoApplyListDTO>> GetAllAutoApplies();
		Task<bool> DeleteVoucher(int id);
		Task<bool> ToggleUse(int id);
	}
}
