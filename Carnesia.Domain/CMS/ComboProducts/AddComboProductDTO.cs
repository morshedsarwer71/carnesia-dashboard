using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class AddComboProductDTO
    {
        public int productId { get; set; }
        public decimal discountAmount { get; set; }
        public decimal regularPrice { get; set; }
        public string productName { get; set; }
        public decimal afterDiscAmount { get; set; }
        public string discountType { get; set; }
        public string sku { get; set; }
        public string comboCode { get; set; }
    }
}
