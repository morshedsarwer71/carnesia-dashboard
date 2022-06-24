using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class POListPoco
    {
        public string poCode { get; set; }
        public string orderDate { get; set; }
        public string vendorName { get; set; }
        public decimal poQuantity { get; set; }
        public decimal totalAmount { get; set; }
        public string poStatus { get; set; }
        public string? statusUpdateDate { get; set; }
    }
}
