using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.AssignDelivery.Dispatch
{
    public class AssignCourierDTO
    {
        public int courierId { get; set; }
        public string carrierName { get; set; }
        public string carrierPhone { get; set; }
        public string trnCode { get; set; }
    }
}
