using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TrackUID
{
    public class TrackUIDDTO
    {
        public string? POID { get; set; }
        public string? OrderID { get; set; }
        public string? TOID { get; set; }
        public string? PickListID { get; set; }
        public string? BIN { get; set; }
        public string LastStatus { get; set; }
        public string StatusUpdateDate { get; set; }
        public string StatusUpdatedBy { get; set; }
    }
}
