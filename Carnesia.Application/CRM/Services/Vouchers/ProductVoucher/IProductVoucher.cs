using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CRM.Vouchers.ProductVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.ProductVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.ProductVoucher
{
    public interface IProductVoucher
    {
        Task<List<ProductVoucherListDTO>> GetAllVouchers();
        Task CreateVoucher(CreateProductVoucherDTO Voucher);
        Task RemoveVoucher(int id);
    }
}
