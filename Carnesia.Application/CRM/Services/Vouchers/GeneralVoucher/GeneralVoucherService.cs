using Carnesia.Domain.CRM.Vouchers.GeneralVoucher.CreateVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CRM.Vouchers.GeneralVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.GeneralVoucher
{
    public class GeneralVoucherService : IGeneralVoucher
    {
        private readonly HttpClient _httpClient;
        public GeneralVoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateNewVoucher(AddGeneralVoucherDTO VoucherData)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Voucher/general", VoucherData);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteVoucher(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Voucher/general/{id}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<VoucherListDTO> GetVoucherById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<VoucherListDTO>($"Voucher/general/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<VoucherListDTO>> GetVouchers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<VoucherListDTO>>("Voucher/general");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
