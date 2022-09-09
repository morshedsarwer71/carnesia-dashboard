using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Picklist.CreatePicklist
{
    public class PicklistFilterDTO
    {
        public string? trnCode { get; set; }
        public string? fromDate { get; set; }
        public string? toDateDate { get; set; }
        public string? productCode { get; set; }
        public string? skuPerOrder { get; set; }
        public string? source { get; set; }
        public string? area { get; set; }
        public int zoneId { get; set; }
    }
}
