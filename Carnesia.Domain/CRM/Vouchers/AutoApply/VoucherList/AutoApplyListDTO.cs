using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.AutoApply.VoucherList
{
	public class AutoApplyListDTO
	{
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal uptoDiscAmnt { get; set; }
        public string description { get; set; }
        public bool isEnabled { get; set; }
        public bool isDeliveryCharge { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string updatedBy { get; set; }
		public string createdBy { get; set; }
	}
}
