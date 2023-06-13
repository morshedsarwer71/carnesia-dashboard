using Carnesia.Domain.AAF.Bank;
using Carnesia.Domain.AAF.Common;
using Carnesia.Domain.AAF.Receivable.DueReceive;
using Carnesia.Domain.AAF.Receivable.Ecommerce;
using Carnesia.Domain.AAF.Receivable.Invoice;
using Carnesia.Domain.AAF.Receivable.Outlet;
using Carnesia.Domain.CMS.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.AAF.Bank
{
    public interface IBank
    {
        Task<List<BankDTO>> GetBanks();
        Task<BankDTO> GetBank(int id);
        Task<bool> CraeteBank(BankDTO bank);
        Task<bool> UpdateBank(BankDTO bank);
        Task<List<OutletOrdersDTO>> GetOutletOrdersByFilter(OutletOrderFilterDTO filter);
        Task<List<EcommerceListDTO>> GetEcommerceOrdersByFilter(EcommerceFilterDTO filter);
        Task<bool> MakeOutletReceive(OutletVM OutletData);
        Task<bool> MakeEcommerceReceive(List<EcommerceReceivableOrdersDTO> OutletData);
        Task<bool> MakeDueReceive(DueReceiveDTO Receive);
        Task<List<PaymentMethodDTO>> GetPaymentMethod();
        Task<List<PaymentMethodDTO>> GetChargeType();
        Task<List<InvoiceListDTO>> GetOutletInvoices();
        Task<List<InvoiceListDTO>> GetOutletInvoicesByFilter(InvoiceFilterDTO Filter);
        Task<List<InvoiceListDTO>> GetEcommerceInvoices();
        Task<string> CreateType(string url);
    }
}
