using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class CreateToTablePoco
    {
        public string SKU { get; set; } 
        public string ProductName { get; set; } 
        public int DestinationWhStock { get; set; } 
        public int SourceWhStock { get; set; } 
        public int TransferQTY { get; set; } 
    }
}
