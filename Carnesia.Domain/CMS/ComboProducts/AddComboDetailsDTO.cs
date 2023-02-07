using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class AddComboDetailsDTO
    {
        public string comboProductName { get; set; }
        //public string sku { get; set; }
        //public int productId { get; set; }
        public int sellQuantity { get; set; }
        public decimal regularPrice { get; set; }
        public int comboPrice { get; set; }
        public string description { get; set; }
        public string richDescription { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string base64Attch { get; set; }
        public string bcType { get; set; } = "Combo";
    }
}
