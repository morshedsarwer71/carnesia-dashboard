using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POFilterPoco
    {
        public string? poid { get; set; }
        public int supplier { get; set; }
        public string SupplierName { get; set; }
        public int status { get; set; } = 5;
        public DateTime? fromDate { get; set; } 
        public DateTime? toDate { get; set; }
    }
}
