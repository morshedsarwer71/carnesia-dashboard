using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.OrderTrack
{
    public class OrderTrackDTO
    {
        public string message { get; set; }
        public string trnCode { get; set; }
        public string customerName { get; set; }
        public DateTime orderDate { get; set; }
        public List<OrderTrackStatusesDTO> statuses { get; set; }
    }

    public class OrderTrackStatusesDTO
    {
        public string status { get; set; }
        public string updatedBy { get; set; }
        public DateTime updatedOn { get; set; }
        public string? editHistory { get; set; }
    }
}
