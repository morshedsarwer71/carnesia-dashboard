using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.ReturnRefund
{
    public class ReturnRefundDTO
    {
        public int received { get; set; }
        public decimal receivedAmount { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int soldQty { get; set; }
        public string? imageUrl { get; set; }
        public string? error { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal returnPrice { get; set; }
        public decimal vat { get; set; }
        public List<ReturnRefundPaymentDTO> payments { get; set; }
    }
	public class ReturnRefundPaymentDTO
    {
		public int id { get; set; }
		public string trnCode { get; set; }
		public string paymentType { get; set; }
		public string? paymentRef { get; set; }
		public decimal amount { get; set; }
		public string? refundPaymentRef { get; set; }
		public decimal refundAmount { get; set; }
		public decimal takenRefundAmount { get; set; }
	}

}
