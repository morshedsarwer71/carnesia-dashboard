using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillPOSDTO
    {
        public Guid uniqUuid { get; set; }
        public GenerateBillPOSTDetailsDTO pos { get; set; }
        public List<GenerateBillUIDDataDTO> items { get; set; }
        public List<GenerateBillUIDDataDTO> combos { get; set; }
        public List<GenerateBillComboProductDTO> comboItems { get; set; }
        public List<GenerateBillUIDCollectionDTO> posUID { get; set; }
        public List<PosPaymentDTO> posPayment { get; set; }
	}

    public class GenerateBillPOSTDetailsDTO
    {
        public decimal total { get; set; }
        public int items { get; set; }
        public int customerId { get; set; }
        public int quantities { get; set; }
        public decimal discount { get; set; }
        public decimal rewardValue { get; set; }
        public decimal vat { get; set; } = 0;
        public decimal vatAmount { get; set; }
        public decimal grandTotal { get; set; }
        public decimal grandTotalWithVat { get; set; }
        public decimal creditValue { get; set; }
        public decimal rewardPoints { get; set; }
        public decimal tobeCollected { get; set; }
        public decimal returnedAmnt { get; set; }
        public string? membershipId { get; set; }
        public string? couponCode { get; set; }
        public string? comment { get; set; }
        public string? refNumber { get; set; }
        public string paymentType { get; set; } = "Cash";
        public string customerPhoneGet { get; set; }
        public string customerPhone { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
    }

    public class PosPaymentDTO
    {
        public string id { get; set; }
        public string paymentType { get; set; } = "Cash";
        public string paymentRef { get; set; }
        public decimal amount { get; set; }
    }
}
