using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.CustomerProfile
{
    public class CustomerProfileDTO
    {
        public string registerDate { get; set; }
        public string customerId { get; set; }
        public string membershipId { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
    }
}
