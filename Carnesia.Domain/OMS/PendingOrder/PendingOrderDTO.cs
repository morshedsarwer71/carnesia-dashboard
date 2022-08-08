using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class PendingOrderDTO
    {
        public int orderId { get; set; }
        public string orderDate { get; set; }
        public string address { get; set; }
        public decimal orderValue { get; set; }
        public string paymentMethod { get; set; }
        public decimal tobeCollected { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string paymentStatus { get; set; }
        public string source { get; set; }
        public string assignto { get; set; }
        public bool ShowDetails { get; set; }
        public PendingOrderDetailsDTO products { get; set; }
    }
}
