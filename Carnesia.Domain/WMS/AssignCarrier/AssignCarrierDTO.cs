using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.AssignCarrier
{
    public class AssignCarrierDTO
    {
        public string createdBy { get; set; }
        public string toCode { get; set; }
        public string status { get; set; }
        public string attemtedBy { get; set; }
        public string sourceWarehouse { get; set; }
        public string destinationWarehouse { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime statusUpdatedOn { get; set; }
    }
}
