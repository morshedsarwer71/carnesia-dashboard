using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Picklist.CreatePicklist
{
    public class CreatePicklistDTO
    {
        public string OrderId { get; set; }
        public string Source { get; set; }
        public string ConsumerName { get; set; }
        public string OrderDate { get; set; }
        public string Phone { get; set; }
        public string Zone { get; set; }
        public string Area { get; set; }
        public string VarificationDate { get; set; }
        public string OrderType { get; set; }
        public string Instruction { get; set; }
        public string Comment { get; set; }
        public bool ShowDetails { get; set; }
        public IList<CreatePicklistDetailsDTO> Details { get; set; }
    }
}
