using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillPOSDTO
    {
        public GenerateBillPOSTDetailsDTO pos { get; set; }
        public List<GenerateBillUIDDataDTO> items { get; set; }
        public List<GenerateBillUIDCollectionDTO> posUID { get; set; }
    }

    public class GenerateBillPOSTDetailsDTO
    {
        public decimal total { get; set; }
        public int items { get; set; }
        public int customerId { get; set; }
        public int quantities { get; set; }
        public decimal discount { get; set; }
        public decimal rewardValue { get; set; }
        public decimal vat { get; set; } = 5;
        public decimal vatAmount { get; set; }
        public decimal grandTotal { get; set; }
        public decimal creditValue { get; set; }
        public decimal rewardPoints { get; set; }
        public string? membershipId { get; set; }
        public string? couponCode { get; set; }
        public string? comment { get; set; }
    }
}
