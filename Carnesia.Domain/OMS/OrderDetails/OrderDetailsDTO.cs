using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.OrderDetails
{
    public class OrderDetailsDTO
    {
        public string Tracking { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string? VerificationDate { get; set; }
        public string? DispatchedDate { get; set; }
        public string Status { get; set; }
        public string HUB { get; set; }
        public string RunNumber { get; set; }
        public string? LastUpdateDate { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBeCollected { get; set; }
    }
}
