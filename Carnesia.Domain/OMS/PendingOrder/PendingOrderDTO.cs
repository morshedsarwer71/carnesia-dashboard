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
        public bool reviewTaken { get; set; }
        public string orderDate { get; set; }
        public string? cancelDate { get; set; }
        public string trnCode { get; set; }
        public string? trackingCode { get; set; }
        public string? instructions { get; set; }
        public string? status { get; set; }
        public string address { get; set; }
        public string reasone { get; set; }
        public string area { get; set; }
        public string zone { get; set; }
        public string verifiedDate { get; set; }
        public decimal orderValue { get; set; }
        public string paymentMethod { get; set; }
        public decimal tobeCollected { get; set; }
        public decimal ratting { get; set; }
        public decimal amount { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string paymentStatus { get; set; }
        public string source { get; set; }
        public string assignto { get; set; }
        public bool ShowDetails { get; set; }
        public DateTime? dispatchDate { get; set; }
        public PendingOrderDetailsDTO products { get; set; }
    }

   public class PendingOrderFilterDTO
    {
        public string trnCode { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string area { get; set; } = "All";
		public int statusId { get; set; }
    }
}
