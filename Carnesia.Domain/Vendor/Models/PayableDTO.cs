using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Vendor.Models
{
    public class PayableDTO
    {
        public string vendorName { get; set; }
        public string initial { get; set; }
        public string owner { get; set; }
        public string phoneNumber { get; set; }
        public string viewAll { get; set; }
        public string paymentProcessing { get; set; }
        public string invoiceCount { get; set; }
        public string poRaised { get; set; }
        public string poQty { get; set; }
        public string recieveQty { get; set; }
        public string currInvenQty { get; set; }
        public string poAmnt { get; set; }
        public string currInvenValue { get; set; }
        public string recieveAmnt { get; set; }
        public string sold { get; set; }
        public string returnAmnt { get; set; }
        public string lost { get; set; }
        public string paid { get; set; }
        public string viewProduct { get; set; }
        public string downloadUID { get; set; }
        public string payable { get; set; }
    }
}
