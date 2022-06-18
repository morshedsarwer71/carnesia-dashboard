using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.POCO
{
    public class TableCommon
    {
        public bool Dense { get; set; } = true;
        public bool Hover { get; set; }=true;
        public bool Bordered { get; set; }=true;
        public bool Striped { get; set; }=true;
        public string SearchTerm { get; set; }
    }
}
