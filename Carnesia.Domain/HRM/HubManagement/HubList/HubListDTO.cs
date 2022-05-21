using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.HubManagement.HubList
{
    public class HubListDTO
    {
        public string HubName { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string ContactNumber { get; set; }
        public bool Active { get; set; }
    }
}
