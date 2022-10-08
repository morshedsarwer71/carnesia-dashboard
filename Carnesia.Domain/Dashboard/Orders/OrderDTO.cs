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
        public string orderId { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        public decimal orderValue { get; set; }
        public string status { get; set; }
        public string? store { get; set; }
        public decimal returnAmount { get; set; }
        public string? paymentMethod { get; set; }
        public string? orderCreatBy { get; set; }
    }

    public class OrderFilterDTO
    {
        public string phoneNumber { get; set; }
        public string trnCode { get; set; }
        public string customerId { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
    }
}
