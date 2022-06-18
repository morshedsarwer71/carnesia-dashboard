using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Bin.Models
{
    public class BinDTO
    {
        public string binName { get; set; }
        public bool isActive { get; set; }=true;
        public int capacity { get; set; }
    }
}
