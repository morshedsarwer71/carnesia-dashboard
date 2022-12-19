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
        Task<VoucherListDTO> GetVoucherById(int id);
        Task<bool> UpdateVoucher(UpdateStoreVoucherDTO voucher);
        Task DeleteVoucher(int id);
        Task<bool> DeleteVoucherStore(int id);
        Task<bool> AddNewStore(int id, CreateStoreVoucherStoreDTO storeId);
        Task<bool> ToggleUse(int id);
    }
}
