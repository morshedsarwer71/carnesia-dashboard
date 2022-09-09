using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.AssignDelivery.Dispatch
{
    public class CourierDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string businessKAM { get; set; }
        public string businessKAMPhone { get; set; }
        public string operationKAM { get; set; }
        public string operationKAMPhone { get; set; }
    }
}
