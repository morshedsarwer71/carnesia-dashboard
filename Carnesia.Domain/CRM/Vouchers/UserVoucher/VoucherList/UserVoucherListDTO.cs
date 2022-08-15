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
        public string startDate { get; set; }
        public string endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public string description { get; set; }
        public string approvedBy { get; set; }
        public object approvelDate { get; set; }
        public string approvalNote { get; set; }
        public bool ShowDetails { get; set; }
        public List<CustomersDTO> customers { get; set; }
    }

    public class CustomersDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public int? customerId { get; set; }
        public bool isUsed { get; set; }
    }
}
