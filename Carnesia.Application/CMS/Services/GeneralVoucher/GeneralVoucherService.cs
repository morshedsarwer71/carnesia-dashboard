using Carnesia.Domain.CMS.GeneralVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.GeneralVoucher
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
    }
}
