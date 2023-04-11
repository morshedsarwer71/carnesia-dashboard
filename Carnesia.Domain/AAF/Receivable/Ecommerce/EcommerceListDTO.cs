using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.Ecommerce
{
    public class EcommerceListDTO
    {
        public string orderId { get; set; }
        public DateTime orderDate { get; set; }
        public decimal amount { get; set; }
        public string paymentMethod { get; set; }
        public string paymentStatus { get; set; }
        public decimal toBeCollected { get; set; }
        public decimal receiveable { get; set; }
        public decimal amountreceived { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public DateTime verifiedOn { get; set; }
        public DateTime dispatchedOn { get; set; }
        public string status { get; set; }
        public DateTime lastUpdatedOn { get; set; }
        public List<PendingOrderProductsDTO> orderProducts { get; set; }
        public bool ShowDetails { get; set; }
    }

    public class EcommerceFilterDTO
    {
        public int courierId { get; set; }
        public int receivingStatus { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public string? tracking { get; set; }
        public string? orderId { get; set; }
    }

    public class EcommerceReceivableOrdersDTO
    {
        public string TrnCode { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal ReceivableAmount { get; set; }
    }
}
