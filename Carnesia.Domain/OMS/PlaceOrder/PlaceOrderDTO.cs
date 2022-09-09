using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PlaceOrder
{
    public class PlaceOrderDTO
    {
        public PlaceOrderDetailsDTO createOrderDTO { get; set; }
    }

    public class PlaceOrderDetailsDTO
    {
        public string voucherCode { get; set; }
        public string source { get; set; }
        public string address { get; set; }
        public string instructions { get; set; }
        public string customerId { get; set; }
        public int autoApplyId { get; set; }
        public decimal autoApplyAmnt { get; set; }
        public decimal totalPrice { get; set; }
        public decimal grandTotalPrice { get; set; }
        public decimal afterPromoPrice { get; set; }
        public decimal promoPrice { get; set; }
        public int paymentType { get; set; }
        public int zoneId { get; set; }
        public int deliveryType { get; set; }
        public int deliveryAddressID { get; set; }
        public decimal deliveryPrice { get; set; }
        public List<ProductTableDTO> orderProductsDTOs { get; set; }
    }
}
