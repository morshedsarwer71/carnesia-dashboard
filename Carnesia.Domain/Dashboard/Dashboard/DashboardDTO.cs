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
        public decimal totalSales { get; set; }
        public int totalItems{ get; set; }
    }
}
