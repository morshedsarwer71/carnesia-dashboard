using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReturnManagement.POCO
{
    public class ReturnAcknowledgementPoco
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int QTY { get; set; }
        public int MissingQTY { get; set; }
        public int RcvQTY { get; set; }
    }
}
