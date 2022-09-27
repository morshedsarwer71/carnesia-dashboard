using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Invoice
{
    public class InvoicePrintDTO
    {
        public string customerPhone { get; set; }
        public string trnCode { get; set; }
        public string customerName { get; set; }
        public string orderDate { get; set; }
        public string address { get; set; }
        public string area { get; set; }
        public string district { get; set; }
        public string shippingZone { get; set; }
        public string payment { get; set; }
        public decimal subtotal { get; set; }
        public decimal discount { get; set; }
        public decimal creditUsed { get; set; }
        public decimal rewardValue { get; set; }
        public decimal grandTotal { get; set; }
        public decimal shippingPrice { get; set; }
        public decimal duePayment { get; set; }
        public List<InvoicePrintProductsDTO> orderProducts { get; set; }
    }

    public class InvoicePrintProductsDTO
    {
        public decimal price { get; set; }
        public decimal total { get; set; }
        public int quantity { get; set; }
        public string productName { get; set; }
    }
}
