using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.UserVoucher.CreateVoucher
{
    public class CreateUserVoucherDTO
    {
        public string uvCode { get; set; }
        public int numOfVoucher { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public int discAmntOrPercent { get; set; }
        public int upToDiscAmnt { get; set; }
        public string description { get; set; }
        public List<CustomersDTO> customers { get; set; }
    }

    public class CustomersDTO
    {
        public string customerGuId { get; set; }
    }
}
