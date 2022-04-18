using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.OutScan
{
    public class OutScanDTO
    {
        public string PickListID { get; set; }
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public string BinCode { get; set; }
        public int QTY { get; set; }
        public int PickedQTY { get; set; }
        public int ToBeScanned { get; set; }
    }
}
