using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.FleetManagement.CourierList
{
    public class CourierListDTO
    {
        public string EnlistDate { get; set; }
        public string CourierName { get; set; }
        public string BusinessKAM { get; set; }
        public string BusinessKAMContact { get; set; }
        public string OperationKAM { get; set; }
        public string OperationKAMContact { get; set; }
        public bool Active { get; set; }
    }
}
