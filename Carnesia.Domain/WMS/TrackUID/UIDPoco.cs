using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TrackUID
{
    public class UIDPoco
    {
        public DateTime? expDate { get; set; }
        public int generateuidQty { get; set; }
        public string productCode { get; set; }
        public string poCode { get; set; }
    }
}
