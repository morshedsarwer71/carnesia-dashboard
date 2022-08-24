using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.PanelUser
{
    public class PanelUserListDTO
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string roleType { get; set; }
        public int? storeId { get; set; }
        public int? departmentId { get; set; }
        public int? designationId { get; set; }
        public string storeName { get; set; }
        public string department { get; set; }
        public string designation { get; set; }
        public string team { get; set; }
        public string jobDescription { get; set; }
        public bool isActive { get; set; }
    }
}
