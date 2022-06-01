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
        public async Task CreateNewVoucher(AddGeneralVoucherDTO VoucherData)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("GeneralVouchers", VoucherData);
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
                var result = await _httpClient.GetFromJsonAsync<List<VoucherListDTO>>("GeneralVouchers");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
