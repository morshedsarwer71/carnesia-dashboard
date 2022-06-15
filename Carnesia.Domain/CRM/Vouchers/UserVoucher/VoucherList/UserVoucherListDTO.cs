using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.UserVoucher.VoucherList
{
    public class UserVoucherListDTO
    {
        public int userVId { get; set; }
        public string uvCode { get; set; }
        public int numOfVoucher { get; set; }
        public int numberOfUsedVoucher { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public int discAmntOrPercent { get; set; }
        public int upToDiscAmnt { get; set; }
        public string description { get; set; }
        public string approvedBy { get; set; }
        public DateTime approvelDate { get; set; }
        public string approvalNote { get; set; }
    }
}
