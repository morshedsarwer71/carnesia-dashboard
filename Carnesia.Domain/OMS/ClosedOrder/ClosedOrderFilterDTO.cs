using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ClosedOrder
{
    public class ClosedOrderFilterDTO
    {
        public string? trnCode { get; set; }
        public string? customerName { get; set; }
        public string? phoneNumber { get; set; }
        public string? area { get; set; }
        public int statusId { get; set; } = 23;
        public DateTime? fromCancelDate { get; set; }
        public DateTime? toCancelDate { get; set; }
    }
}
