using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POListPoco
    {
        public DateTime? Date { get; set; }
        public string POID { get; set; }    
        public string Supplier { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
    }
}
