using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class PendingOrderDTO
    {
        public string OrderId { get; set; }
        public string OrderDate { get; set; }
        public decimal OrderValue { get; set; }
        public string PaymentMethode { get; set; }
        public decimal ToBeCollected { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public string AssignTo { get; set; }
        public bool Verified { get; set; }
        public bool ShowDetails { get; set; }
        public IList<PendingOrderDetailsDTO> Details { get; set; }
    }
}
