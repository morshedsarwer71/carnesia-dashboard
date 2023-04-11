using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.Outlet
{
	public class OutletOrderFilterDTO
	{
		public DateTime? fromDate { get; set; }
		public DateTime? toDate { get; set; }
        public int storeId { get; set; }
	}
	public class OutletOrdersDTO
	{
		public DateTime orderDate { get; set; }
		public string orderId { get; set; }
		public string customerName { get; set; }
		public string phoneNumber { get; set; }
		public string couponCode { get; set; }
		public decimal discount { get; set; }
		public decimal grandTotal { get; set; }
		public string soldBy { get; set; }
		public decimal mrp { get; set; }
		public decimal salesAmount { get; set; }
	}

    public class OutletVM
    {
        public AccountsReceivableDTO receivableDto { get; set; }
        public IEnumerable<ReceivableOrdersDTO> orders { get; set; }
    }

    public class AccountsReceivableDTO
    {
        public int bankId { get; set; }
        public int chargeTypeId { get; set; } = 1;
        public int paymentMethodId { get; set; } = 1;
        public decimal transCharge { get; set; }
        public decimal totalInvoiceAmnt { get; set; }
        public decimal totalReceivedAmnt { get; set; }
        public DateTime transDate { get; set; }
        public DateTime? transDateTemp { get; set; }
        public string? transReference { get; set; }
        public int buid { get; set; }
        public string? remarks { get; set; }
    }

    public class ReceivableOrdersDTO
    {
        public string trnCode { get; set; }
        public decimal totalAmount { get; set; }
    }
}
