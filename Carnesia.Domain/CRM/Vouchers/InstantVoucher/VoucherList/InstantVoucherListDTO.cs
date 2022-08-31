using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.InstantVoucher.VoucherList
{
    public class InstantVoucherListDTO
    {
        public int instantVId { get; set; }
        public string ivCode { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public object approvalDate { get; set; }
        public string approvedBy { get; set; }
        public string description { get; set; }
        public bool isEnabled { get; set; }
    }
}
