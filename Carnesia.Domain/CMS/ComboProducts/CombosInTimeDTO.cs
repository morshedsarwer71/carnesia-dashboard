using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class CombosInTimeDTO
    {

        public int comboId { get; set; }
        public string comboName { get; set; }
        public decimal comboPrice { get; set; }
        public decimal regularPrice { get; set; }
    }
}

