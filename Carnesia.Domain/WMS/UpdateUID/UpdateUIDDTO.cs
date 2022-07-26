using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UpdateUID
{
    public class UpdateUIDDTO
    {
        public int id { get; set; }
        public int generatedSKUQty { get; set; }
        public string sku { get; set; }
        public string expDate { get; set; }
        public string paramDate { get; set; }
        public bool showDetails { get; set; } = false;
        public List<UIDSDTO> uid { get; set; }
    }

    public class UIDSDTO
    {
        public string uidCode { get; set; }
    }
}
