using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.OMS.PickPack
{
    public class PickPackDTO
    {
        public string PicklistID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int QTY { get; set; }
        public int QTYPacked { get; set; }
        public int ToBeScanned { get; set; }
    }
}
