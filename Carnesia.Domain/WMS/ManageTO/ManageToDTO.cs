using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ManageTO
{
    public class ManageToDTO
    {
        public int toId { get; set; }
        public string createdDate { get; set; }
        public string toCode { get; set; }
        public string sourchWh { get; set; }
        public string destinationWh { get; set; }
        public string poType { get; set; }
        public string status { get; set; }
        public int statusId { get; set; }
        public string lastUpdate { get; set; }
        public int toQuantity { get; set; }
        public string? pickListId { get; set; }
    }
}
