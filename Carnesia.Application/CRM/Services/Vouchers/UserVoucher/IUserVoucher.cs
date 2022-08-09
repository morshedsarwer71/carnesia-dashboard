using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.UserVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.UserVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.UserVoucher
{
    public interface IUserVoucher
    {
        Task<List<UserVoucherListDTO>> GetAllVouchers();
        Task<bool> CreateUserVoucher(CreateUserVoucherDTO Voucher);
        Task RemoveVoucher(int id);
    }
}
