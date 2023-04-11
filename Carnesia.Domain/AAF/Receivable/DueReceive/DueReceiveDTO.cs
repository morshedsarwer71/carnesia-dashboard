using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.DueReceive
{
    public class DueReceiveDTO
    {
        public string invoiceCode { get; set; }
        public decimal amount { get; set; }
        public int bankId { get; set; }
        public int chargeTypeId { get; set; } = 1;
        public int paymentMethodId { get; set; } = 1;
        public decimal transCharge { get; set; }
        public decimal totalInvoiceAmnt { get; set; }
        public DateTime? transDate { get; set; }
        public string? transReference { get; set; }
        public int buid { get; set; }
        public string? remarks { get; set; }
    }
}
