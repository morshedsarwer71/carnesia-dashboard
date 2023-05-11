using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Stores
{
    public class StoresDTO
    {
        public int storeId { get; set; }
        public string name { get; set; }
        public bool isVatable { get; set; }
        public DateTime updatedAt { get; set; }
        public string updateBy { get; set; }
        public string type { get; set; }
    }
}
