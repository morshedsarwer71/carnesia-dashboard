using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.StoreVoucher.CreateStoreVoucher
{
    public class CreateStoreVoucherDTO
    {
        public CreateStoreVoucherDetailsDTO createStoreVoucherDTO { get; set; }
        public List<CreateStoreVoucherStoreDTO> voucherStoreDTOs { get; set; }
    }
}
