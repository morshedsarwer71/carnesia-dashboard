using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Bin.Models
{
    public class GetBinDTO
    {
        public int id { get; set; }
        public string binName { get; set; }
        public string status { get; set; }
        public bool isActive { get; set; }
        public string store { get; set; }
        public int storeId { get; set; }
        public string createdAt { get; set; }
        public string createdBy { get; set; }
        public int currentStock { get; set; }
        public int capacity { get; set; }
    }
}
