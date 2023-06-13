using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.SalesReport
{
	public class SalesReportDTO
	{
        public string storeName { get; set; }
        public decimal totalSale { get; set; }
        public decimal grandTotal { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal totalRefund { get; set; }
        public decimal creditUsed { get; set; }
        public decimal rcvdByAccountsAmnt { get; set; }
        public decimal pendingAmount { get; set; }
        public decimal lostAmount { get; set; }
        public decimal vatAmmount { get; set; }
        public int totalItems { get; set; }
        public int totalQty { get; set; }
        public int totalOrders { get; set; }
        public int storeId { get; set; }
        public DateTime date { get; set; }
    }

    public class SalesReportPaymentTypeDTO
	{
        public string paymentType { get; set; }
        public decimal amount { get; set; }

    }
}
