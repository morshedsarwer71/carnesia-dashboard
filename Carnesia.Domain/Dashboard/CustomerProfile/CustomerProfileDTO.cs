using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.CustomerProfile
{
    public class CustomerProfileDTO
    {
        public string regDate { get; set; }
        public int? customerId { get; set; }
        public string memberId { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string address { get; set; }
    }
}
