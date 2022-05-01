using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Picklist.DirectOrderPrint
{
    public class DirectOrderPrintDTO
    {
        public string OrderID { get; set; }
        public string Source { get; set; }
        public string OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Area { get; set; }
        public string Zone { get; set; }
        public string VarifiedOn { get; set; }
        public string Instructions { get; set; }
        public string OrderType { get; set; }
        public string Comment { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details {get; set;}
    }
}
