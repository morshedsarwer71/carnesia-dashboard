using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.Orders
{
    public class OrderDTO
    {
        public string orderDate { get; set; } 
        public string orderID { get; set; } 
        public string customerID { get; set; } 
        public string customerName { get; set; } 
        public string address { get; set; } 
        public string status { get; set; } 
        public decimal orderValue { get; set; } 
        public bool showDetails { get; set; } = false;
        public IList<OrderDetailsDTO> details { get; set; }
    }
}
