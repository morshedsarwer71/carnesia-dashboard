using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.RevenueReport
{
    public class RevenueReportDTO
    {
        public string orderTrnId { get; set; }
        public string productCode { get; set; }
        public string productsku { get; set; }
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal mrp { get; set; }
        public decimal totalPrice { get; set; }
        public decimal promoPrice { get; set; }
        public decimal deliveryPrice { get; set; }
        public decimal grandTotalPrice { get; set; }
        public string name { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? dispatchDate { get; set; }
        public DateTime? updatedAt { get; set; }
        public string PickListCode { get; set; }
    }
}
