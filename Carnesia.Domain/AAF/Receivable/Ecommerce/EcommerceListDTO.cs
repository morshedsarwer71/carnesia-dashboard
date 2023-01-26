using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.Ecommerce
{
    public class EcommerceListDTO
    {
        public int orderId { get; set; }
        public string orderDate { get; set; }
        public string trnCode { get; set; }
        public string? trackingCode { get; set; }
        public string? status { get; set; }
        public string address { get; set; }
        public string area { get; set; }
        public string zone { get; set; }
        public string verifiedDate { get; set; }
        public string dispatchedDate { get; set; }
        public string instructions { get; set; }
        public decimal orderValue { get; set; }
        public string paymentMethod { get; set; }
        public decimal tobeCollected { get; set; }
        public decimal ratting { get; set; }
        public decimal amount { get; set; }
        public decimal amountReceived { get; set; }
        public decimal receivable { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string paymentStatus { get; set; }
        public string source { get; set; }
        public string assignto { get; set; }
        public string hub { get; set; }
        public string location { get; set; }
        public string runNumber { get; set; }
        public string lastUpdateDate { get; set; }
        public bool ShowDetails { get; set; }
    }
}
