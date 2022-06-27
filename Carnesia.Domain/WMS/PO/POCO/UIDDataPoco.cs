using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class UIDDataPoco
    {
        public int id { get; set; }
        public string profileCode { get; set; }
        public string uidCode { get; set; }
        public bool isDelivered { get; set; }
    }
}
