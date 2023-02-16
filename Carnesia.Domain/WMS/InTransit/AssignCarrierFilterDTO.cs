using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.InTransit
{
    public class AssignCarrierFilterDTO
    {
        public int status { get; set; }
        public string? toCode { get; set; }
    }
}
