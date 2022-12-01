using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.MIS.Revenue
{
    public class ProdRevenueAndProfitDTO
    {
        public string bu { get; set; }
        public string ecomOrOutlet { get; set; }
        public string childCat { get; set; }
        public string brand { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string soldQty { get; set; }
        public string sellingPrice { get; set; }
        public string soldValue { get; set; }
        public string totalCost { get; set; }
        public string profit { get; set; }
    }

    public class TotalRevProfitDTO
    {
        public string soldTotal { get; set; }
        public string product { get; set; }
        public string quantity { get; set; }
        public string totalCost { get; set; }
        public string profit { get; set; }
    }
}
