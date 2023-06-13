using Carnesia.Domain.AAF.Bank;
using Carnesia.Domain.AAF.Common;
using Carnesia.Domain.AAF.Receivable.DueReceive;
using Carnesia.Domain.AAF.Receivable.Ecommerce;
using Carnesia.Domain.AAF.Receivable.Invoice;
using Carnesia.Domain.AAF.Receivable.Outlet;
using Carnesia.Domain.WMS.POReport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.AAF.Bank
{
    public class BankService : IBank
    {
        private readonly HttpClient _httpClient;
        public BankService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CraeteBank(BankDTO bank)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/addbank", bank);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> CreateType(string url)
        {
            try
            {
                var result = await _httpClient.GetStringAsync(url);
                return result.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BankDTO> GetBank(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BankDTO>($"accounting/bank/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BankDTO>> GetBanks()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BankDTO>>("accounting/banks");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PaymentMethodDTO>> GetChargeType()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PaymentMethodDTO>>("accounting/chargetype");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<InvoiceListDTO>> GetEcommerceInvoices()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<InvoiceListDTO>>("accounting/ecommerceinvoices");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EcommerceListDTO>> GetEcommerceOrdersByFilter(EcommerceFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/ecommerceorders", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<EcommerceListDTO>>(json);

                return data;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<List<InvoiceListDTO>> GetOutletInvoices()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<InvoiceListDTO>>("accounting/outletinvoices");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<InvoiceListDTO>> GetOutletInvoicesByFilter(InvoiceFilterDTO Filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/outletinvoicesbyfilter", Filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<InvoiceListDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<OutletOrdersDTO>> GetOutletOrdersByFilter(OutletOrderFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/outletorders", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<OutletOrdersDTO>>(json);

                return data;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PaymentMethodDTO>> GetPaymentMethod()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PaymentMethodDTO>>("accounting/paymentmethod");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> MakeDueReceive(DueReceiveDTO Receive)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/receivedbyinvoice", Receive);
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> MakeEcommerceReceive(List<EcommerceReceivableOrdersDTO> OutletData)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/accountsreceivableecommerce", OutletData);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> MakeOutletReceive(OutletVM OutletData)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/accountsreceivable", OutletData);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBank(BankDTO bank)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"accounting/updatebank/{bank.id}", bank); 
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
