using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.StoreVoucher.CreateStoreVoucher;
using Carnesia.Domain.CRM.Vouchers.StoreVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.StoreVoucher
{
    public interface IStoreVoucher
    {
        Task<bool> CreateStoreVoucher(CreateStoreVoucherDTO Voucher);
        Task<List<VoucherListDTO>> GetAllVouchers();
        Task DeleteVoucher(int id);
    }
}
