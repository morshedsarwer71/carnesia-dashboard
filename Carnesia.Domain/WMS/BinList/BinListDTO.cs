using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinList
{
    public class BinListDTO
    {
        public string BIN { get; set; }
        public string Status { get; set; }
        public string Warehouse { get; set; }
        public string CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public int CurrentCap { get; set; }
        public int CurrentStock { get; set; }
    }
}
