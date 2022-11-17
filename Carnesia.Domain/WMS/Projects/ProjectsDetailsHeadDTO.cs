using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Projects
{
    public class ProjectsDetailsHeadDTO
    {
        public string? binName { get; set; }
        public DateTime? lastCountDate { get; set; }
        public string? projectCode { get; set; }
        public string? poCode { get; set; }
        public string message { get; set; }
        public List<ProjectsDetailsDTO>? productDetails { get; set; }
    }

    public class ProjectsDetailsDTO
    {
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string binName { get; set; }
        public string? poCode { get; set; }
        public int quantity { get; set; }
        public int foundQty { get; set; }
    }
}
