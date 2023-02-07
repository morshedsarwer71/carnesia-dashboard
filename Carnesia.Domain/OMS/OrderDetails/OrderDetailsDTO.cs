using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.OrderDetails
{
    public class OrderDetailsDTO
    {
        public string Tracking { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string? VerificationDate { get; set; }
        public string? DispatchedDate { get; set; }
        public string Status { get; set; }
        public string HUB { get; set; }
        public string RunNumber { get; set; }
        public string? LastUpdateDate { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBeCollected { get; set; }
        public bool ShowDetails { get; set; }
        public IList<OrderDetailsProductsDTO> Details { get; set; }
    }

    public class OrderDetailsFilterDTO
    {
        public string? trnCode { get; set; }
        public DateTime? fromOrderDate { get; set; }
        public DateTime? toOrderDate { get; set; }
        public DateTime? fromPackingDate { get; set; }
        public DateTime? toPackingDate { get; set; }
        public DateTime? fromDispatchDate { get; set; }
        public DateTime? toDispatchDate { get; set; }
        public string? sortBy { get; set; }
        public string? source { get; set; }
        public string? customerName { get; set; }
        public string? sku { get; set; }
        public string? productName { get; set; }
        public string? productCode { get; set; }
        public string? shippingArea { get; set; }
        public string? phoneNumber { get; set; }
        public int courierId { get; set; }
        public int statusId { get; set; }
        public int zoneId { get; set; }
    }
}
