using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReturnManagement.POCO
{
    public class ReturnListTablePoco
    {
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Type { get; set; }
        public string Supplier { get; set; }
        public string Status { get; set; }
        public int ReturnNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

    }
}
