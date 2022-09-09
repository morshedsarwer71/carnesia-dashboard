using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PlaceOrder
{
    public class PlaceOrderCouponDTO
    {
        public decimal minCartAmmount { get; set; }
        public string? discountType { get; set; }
        public decimal percentageOrAmount { get; set; }
        public decimal uptoDiscountAmount { get; set; }
        public string? voucherCode { get; set; }
        public string? message { get; set; }
    }
}
