using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class AwaitingApprovalPoco
    {
        public string PoCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string VendorName { get; set; }
        public int Quatity { get; set; }
        public decimal TotalAmount { get; set; }
        public string PoStatus { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
    }
}
