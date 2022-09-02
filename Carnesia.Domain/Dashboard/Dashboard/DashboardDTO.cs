using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.Dashboard
{
    public class DashboardDTO
    {
        public string storeName { get; set; }
        public decimal totalSale { get; set; }
        public decimal grandTotal { get; set; }
        public int totalItems { get; set; }
    }
}
