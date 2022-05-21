using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ReturnManagement.PendingReturn
{
    public class PendingReturnDTO
    {
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string ReturnDate { get; set; }
        public int QTY { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details { get; set; }
    }
}
