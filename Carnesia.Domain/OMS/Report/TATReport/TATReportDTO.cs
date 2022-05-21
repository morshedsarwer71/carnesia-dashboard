using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Report.TATReport
{
    public class TATReportDTO
    {
        public string Tracking { get; set; }
        public string OrderId { get; set; }
        public string OrderDate { get; set; }
        public string? AwatingPickupDate { get; set; }
        public string PickedUpOn { get; set; }
        public string AwaitingDispatchDate { get; set; }
        public string DispatchedOn { get; set; }
        public string? DeliveredOn { get; set; }
        public string? Courier { get; set; }
        public string? ReturnCreatedOn { get; set; }
        public string? CancelledOn { get; set; }
        public string CurrentStatus { get; set; }
        public string HUB { get; set; }
        public decimal Amount { get; set; }
        public int? DeliveryTAT { get; set; }
    }
}
