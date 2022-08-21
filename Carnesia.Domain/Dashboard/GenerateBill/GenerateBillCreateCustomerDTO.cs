using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
	public class GenerateBillCreateCustomerDTO
	{
        public string firstName { get; set; }
        public string? lastName { get; set; }
        public string phoneNumber { get; set; }
        public string? email { get; set; }
        public string? memebershipId { get; set; }
        public string? address { get; set; }
    }
}
