using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.OrderDetails
{
    public class OrderDetailsTrackingDTO
    {
        public string? Status { get; set; }
        public string? UpdateDate { get; set; }
        public string? Comments { get; set; }
        public string? AttendedBy { get; set; }
        public string? UpdateBy { get; set; }
        public string HUB { get; set; }
        public string? Instruction { get; set; }
    }
}
