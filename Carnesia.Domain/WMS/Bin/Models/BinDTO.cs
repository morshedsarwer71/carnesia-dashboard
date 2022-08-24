using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Bin.Models
{
    public class BinDTO
    {
        public int storeId { get; set; }
        public int id { get; set; }
        public string binName { get; set; }
        public bool isActive { get; set; } = true;
        public int capacity { get; set; }
        public int floor { get; set; }
        public int room { get; set; }
        public int column { get; set; }
        public int rack { get; set; }
        public int shelf { get; set; }
        public int bin { get; set; }
    }
}
