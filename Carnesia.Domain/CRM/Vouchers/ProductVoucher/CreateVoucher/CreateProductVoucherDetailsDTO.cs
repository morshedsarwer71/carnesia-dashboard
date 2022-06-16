using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.ProductVoucher.CreateVoucher
{
    public class CreateProductVoucherDetailsDTO
    {
        public string pvCode { get; set; }
        public int numOfVoucher { get; set; }
        public int? numberOfUsedVoucher { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public DateTime? approvalDate { get; set; }
        public string? approvedBy { get; set; }
        public string description { get; set; }
    }
}
