using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ManageRun.ClosedRun
{
    public class ClosedRunDTO
    {
        public string RunType { get; set; }
        public string RunNumber { get; set; }
        public string Courier { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverPhone { get; set; }
        public string CreatedBy { get; set; }
        public string? Status { get; set; }
        public int QTY { get; set; }
        public decimal Amount { get; set; }
    }
}
