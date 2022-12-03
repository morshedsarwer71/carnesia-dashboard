using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillInvoiceDTO
    {
        public decimal total { get; set; }
        public int numOfItems { get; set; }
        public int customerId { get; set; }
        public int quantities { get; set; }
        public decimal rewardPoints { get; set; }
        public decimal discount { get; set; }
        public decimal creditUsed { get; set; }
        public decimal vat { get; set; }
        public decimal vatAmount { get; set; }
        public decimal grandTotal { get; set; }
        public string trnCode { get; set; }
        public string outletAddress { get; set; }
        public string outletPhone { get; set; }
        public string orderDate { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string customerAddress { get; set; }
        public string area { get; set; }
        public string district { get; set; }
        public string shippingZone { get; set; }
        public string paymentType { get; set; }
        public List<GenerateBillInvoiceItemDTO> items { get; set; }
        public List<GenerateBillPaymentsDTO> payments { get; set; }
    }

    public class GenerateBillInvoiceItemDTO
    {
        public string productCode { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
    }

    public class GenerateBillPaymentsDTO
    {
		public string paymentType { get; set; }
		public string? paymentRef { get; set; }
		public decimal amount { get; set; }
	}
}
