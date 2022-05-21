using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.OMS.OpenRun
{
    public class OpenRunDTO
    {
        public string OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string PaymentMethode { get; set; }
        public string Address { get; set; }
        public string Zone { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBeCollected { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details { get; set; }
    }
}
