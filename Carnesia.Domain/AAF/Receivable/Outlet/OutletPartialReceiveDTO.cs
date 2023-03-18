using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.Outlet
{
    public class OutletPartialReceiveDTO
    {
        public AccountsReceivableDTO ReceivableDto { get; set; }
        public IEnumerable<ReceivableOrdersDTO> Orders { get; set; }
    }

    public class AccountsReceivableDTO
    {
        public int bankId { get; set; }
        public int chargeTypeId { get; set; }
        public int paymentMethodId { get; set; }
        public decimal transCharge { get; set; }
        public decimal totalInvoiceAmnt { get; set; }
        public decimal totalReceivedAmnt { get; set; }
        public DateTime transDate { get; set; }
        public string? transReference { get; set; }
        public int buid { get; set; }
        public string? remarks { get; set; }
    }

    public class ReceivableOrdersDTO
    {
        public string trnCode { get; set; }
        public decimal totalAmount { get; set; }
    }

    public class OutletOrdersFilterDTO
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public int storeId { get; set; }
    }
}
