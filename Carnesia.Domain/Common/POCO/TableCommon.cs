using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.POCO
{
    public class TableCommon
    {
        public bool Dense { get; set; }
        public bool Hover { get; set; }
        public bool Bordered { get; set; }
        public bool Striped { get; set; }
        public string SearchTerm { get; set; }
    }
}
