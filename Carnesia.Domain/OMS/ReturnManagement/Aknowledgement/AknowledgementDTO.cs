using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ReturnManagement.Aknowledgement
{
    public class AknowledgementDTO
    {
        public string ReceivingDate { get; set; }
        public string Courier { get; set; }
        public string? ReturnReceivedBy { get; set; }
        public string OrderID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int QTY { get; set; }
        public int Received { get; set; }
        public int Damaged { get; set; }
        public int Missing { get; set; }
    }
}
