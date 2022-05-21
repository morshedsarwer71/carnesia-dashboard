using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Report.FeedbackReport
{
    public class FeedbackReportDTO
    {
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethode { get; set; }
        public decimal ToBeCollected { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string HUB { get; set; }
        public string AssignTo { get; set; }
        public string Action { get; set; }
        public string Rating { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details { get; set; }
    }
}
