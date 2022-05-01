using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Picklist.Picklistreport
{
    public class PicklistReportDTO
    {
        public string PicklistId { get; set; }
        public string PicklistType { get; set; }
        public string CreationDate { get; set; }
        public int TotalQuantity { get; set; }
        public int Picked { get; set; }
        public int Status { get; set; }
    }
}
