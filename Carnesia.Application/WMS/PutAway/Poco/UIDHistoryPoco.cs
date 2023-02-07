using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.PutAway.Poco
{
    public class UIDHistoryPoco
    {
        public string uid { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string image { get; set; }
        public string? expDate { get; set; }
        public int age { get; set; }
        public IEnumerable<TrackUID> trackUIDs { get; set; }
    }

    public class TrackUID
    {
        public string uid { get; set; }
        public string? poCode { get; set; }
        public string status { get; set; }
        public string? orderCode { get; set; }
        public string? toCode { get; set; }
        public string? pickListCode { get; set; }
        public string? binId { get; set; }
        public string? createdBy { get; set; }
        public string createdAt { get; set; }
    }
}
