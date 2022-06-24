using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POFilterPoco
    {
        public string? POID { get; set; }
        public int Supplier { get; set; }
        public string SupplierName { get; set; }
        public int Status { get; set; } = 5;
        public string fromDate { get; set; } 
        public string toDate { get; set; } 
        //public DateRange DateFromTo { get; set; }
    }
}
