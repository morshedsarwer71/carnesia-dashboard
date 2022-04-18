using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.InTransit
{
    public class InTransitDTO
    {
        public string CreationData { get; set; }
        public string TOID { get; set; }
        public string SourceWH { get; set; }
        public string DestinationWH { get; set; }
        public string AttemtedBy { get; set; }
        public string Status { get; set; }
        public string StatusUpdateDate { get; set; }
    }
}
