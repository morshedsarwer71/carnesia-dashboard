using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.GeneralVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.GeneralVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.GeneralVoucher
{
    public interface IGeneralVoucher
    {
        Task CreateNewVoucher(AddGeneralVoucherDTO VoucherData);

        Task<List<VoucherListDTO>> GetVouchers();
    }
}
