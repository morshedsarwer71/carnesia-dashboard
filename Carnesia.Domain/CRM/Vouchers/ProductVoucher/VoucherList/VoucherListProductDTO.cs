using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.ProductVoucher.VoucherList
{
    public class VoucherListProductDTO
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public decimal mrp { get; set; }
    }
}
