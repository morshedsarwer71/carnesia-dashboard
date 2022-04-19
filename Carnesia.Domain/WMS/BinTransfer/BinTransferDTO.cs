using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinTransfer
{
    public class BinTransferDTO
    {
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public string BIN { get; set; }
        public string Image { get; set; }
        public int QTY { get; set; }
    }
}
