using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ManageTO
{
    public class ManageToDTO
    {
        public string CreationDate { get; set; }
        public string TOID { get; set; }
        public string SourceWH { get; set; }
        public string DestinationWH { get; set; }
        public string ToType { get; set; }
        public string Status { get; set; }
        public string UpadetDate { get; set; }
        public string PickListID { get; set; }
        public int ToProductQuantity { get; set; }
    }
}
