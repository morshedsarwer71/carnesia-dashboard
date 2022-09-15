using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Picklist.GeneratedPicklist
{
    public class GeneratedPicklistDTO
    {
        public string pickListCode { get; set; }
        public string orders { get; set; }
        public int numberOfOrders { get; set; }
        public string generateBy { get; set; }
        public DateTime date { get; set; }
    }

    public class RemoveFromPicklistDTO
    {
        public string pickCode { get; set; }
        public string orderCode { get; set; }
    }
}
