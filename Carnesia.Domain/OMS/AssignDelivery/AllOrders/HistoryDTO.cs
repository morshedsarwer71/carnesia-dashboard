using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.AssignDelivery.AllOrders
{
    public class HistoryDTO
    {
        public string Status { get; set; }
        public string UpdatedOn { get; set; }
        public string Comments { get; set; }
        public string AttendedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Hub { get; set; }
        public string Instruction { get; set; }
    }
}
