using Carnesia.Domain.CRM.Vouchers.UserVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.UserVoucher.VoucherList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CRM.Services.Vouchers.UserVoucher
{
    public class UserVoucherService : IUserVoucher
    {
        private readonly HttpClient _httpClient;
        public UserVoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateUserVoucher(CreateUserVoucherDTO Voucher)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Voucher/user", Voucher);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<UserVoucherListDTO>> GetAllVouchers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<UserVoucherListDTO>>("Voucher/user");
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
                await _httpClient.DeleteAsync($"Voucher/user/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
