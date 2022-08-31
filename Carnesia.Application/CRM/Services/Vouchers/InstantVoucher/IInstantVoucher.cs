using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.InstantVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.InstantVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.InstantVoucher
{
    public interface IInstantVoucher
    {
        Task<bool> CreateInstantVoucher(CreateInstantVoucherDTO Voucher);
        Task<List<InstantVoucherListDTO>> GetAllVouchers();
        Task RemoveVoucher(int id);
        Task<bool> ToggleUse(int id);
    }
}
