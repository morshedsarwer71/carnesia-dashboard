using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ClosedOrder
{
    public class ClosedOrderDTO
    {
        public string Tracking { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string? AssignTo { get; set; }
        public string Feedback { get; set; }
        public string Status { get; set; }
        public string HUB { get; set; }
        public decimal Rating { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBeCollected { get; set; }
        public bool ShowDetails { get; set; }
        public IList<ClosedOrderProductsDTO> Details { get; set; }
    }
}
