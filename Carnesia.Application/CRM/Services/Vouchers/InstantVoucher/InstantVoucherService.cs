using Carnesia.Domain.CRM.Vouchers.InstantVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.InstantVoucher.VoucherList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CRM.Services.Vouchers.InstantVoucher
{
    public class InstantVoucherService : IInstantVoucher
    {
        private readonly HttpClient _httpClient;
        public InstantVoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateInstantVoucher(CreateInstantVoucherDTO Voucher)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Voucher/instant", Voucher);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<InstantVoucherListDTO>> GetAllVouchers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<InstantVoucherListDTO>>("Voucher/instant");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task RemoveVoucher(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Voucher/instant/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleUse(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync($"Voucher/toggleinstant/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
