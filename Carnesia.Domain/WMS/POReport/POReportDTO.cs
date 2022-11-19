using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.POReport
{
    public class POReportDTO
    {
        public DateTime CreatedAt { get; set; }
        public string SupplierName { get; set; }
        public string POID { get; set; }
        public string ReceivingWH { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string productCode { get; set; }
        public decimal LiftingPrice { get; set; }
        public decimal ReceivedValue { get; set; }
        public int POQTY { get; set; }
        public int ReceivingQTY { get; set; }
        public int notArrived { get; set; }
        public int uidGenerated { get; set; }
        public int uidGenerateLeft { get; set; }
        public int inscanComplete { get; set; }
        public int inscanLeft { get; set; }
    }
}
