using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.AssignDelivery.AllOrders
{
    public class AllOrdersDTO
    {
        public string OrderType { get; set; }
        public string Tracking { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string PaymentMethode { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string VerifiedOn { get; set; }
        public string DispatchedOn { get; set; }
        public string Status { get; set; }
        public string Hub { get; set; }
        public string Location { get; set; }
        public string RunNumber { get; set; }
        public string UpdateDate { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBeCollected { get; set; }
        public bool ShowDetails { get; set; }
        public IList<DetailsDTO> Details { get; set; }
    }
}
