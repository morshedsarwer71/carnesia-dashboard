using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Vendor.Models
{
    public class PayablePODTO
    {
        public string POCreatedOn { get; set; }
        public string ReceivingDate { get; set; }
        public string POType { get; set; }
        public string POID { get; set; }
        public string POQty { get; set; }
        public string ReceivedQty { get; set; }
        public string CurentInventoryQty { get; set; }
        public string POAmount { get; set; }
        public string CurentInventoryValue { get; set; }
        public string ReceivedAmount { get; set; }
        public string POStatus { get; set; }
        public string SoldUidValue { get; set; }
        public string ReturnedAmount { get; set; }
        public string lost { get; set; }
        public string paid { get; set; }
        public string Processing { get; set; }
        public string ViewProducts { get; set; }
        public string DownloadUid { get; set; }
        public string POCreatedBy { get; set; }
        public string POReceivedBy { get; set; }
        public string POStatusChangedOn { get; set; }
        public string PaymentStatus { get; set; }
        public string Payable { get; set; }
        public string Pay { get; set; }
    }
}
