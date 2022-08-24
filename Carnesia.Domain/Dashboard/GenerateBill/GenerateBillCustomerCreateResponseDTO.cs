using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillCustomerCreateResponseDTO
    {
        public string status { get; set; }
        public string message { get; set; }
        public int? customerId { get; set; }
    }
}
