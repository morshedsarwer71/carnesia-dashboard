using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.StoreVoucher.VoucherList
{
    public class VoucherListDTO
    {
        public int id { get; set; }
        public string voucherCode { get; set; }
        public int numOfVoucher { get; set; }
        public int numberOfUsege { get; set; }
        public string startDate { get; set; }
        public TimeSpan? startTime { get; set; }
        public string endDate { get; set; }
        public TimeSpan? endTime { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public string description { get; set; }
        public bool isEnable { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string updatedBy { get; set; }
		public string createdBy { get; set; }
		public List<VoucherListStoreDTO> voucherStores { get; set; }
    }

    public class UpdateStoreVoucherDTO
    {
        public int id { get; set; }
        public string voucherCode { get; set; }
        public int numOfVoucher { get; set; }
        public int numberOfUsege { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public string description { get; set; }
    }
}
