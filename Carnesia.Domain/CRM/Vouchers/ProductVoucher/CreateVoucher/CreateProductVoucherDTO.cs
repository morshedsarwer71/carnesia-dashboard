using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.ProductVoucher.CreateVoucher
{
    public class CreateProductVoucherDTO
    {
        public CreateProductVoucherDetailsDTO createProductVoucherDTO { get; set; }
        public List<CreateProductVoucherProductDTO> prodVoucherProductsDTOs { get; set; }
    }
}
