using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ReturnManagement.PendingReturn
{
    public class PendingReturnDTO
    {
        public string orderCode { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? returnDate { get; set; }
        public decimal sellingPrice { get; set; }
        public int totalQty { get; set; }
        public decimal amount { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details { get; set; }
    }

    public class PendingReturnsFilterDTO
    {
        public string orderCode { get; set; }
        public int courierId { get; set; }
        public string delivedryRcvId { get; set; }
        public DateTime? returnFromDate { get; set; }
        public DateTime? returnToDate { get; set; }
    }
}
