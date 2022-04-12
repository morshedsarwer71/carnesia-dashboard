using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POFilterPoco
    {
        public string POID { get; set; }
        public string Supplier { get; set; }
        public string Status { get; set; }
        //public DateRange DateFromTo { get; set; }
    }
}
