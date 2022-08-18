using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillCustomerInfoDTO
    {
        public string? name { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? error { get; set; }
        public int customerId { get; set; }
        public decimal creditValue { get; set; }
    }
}
