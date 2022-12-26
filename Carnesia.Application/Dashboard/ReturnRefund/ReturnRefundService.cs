using Carnesia.Domain.Dashboard.ReturnRefund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.Dashboard.ReturnRefund
{
    public class ReturnRefundService : IReturnRefund
    {
        private readonly HttpClient _httpClient;
        public ReturnRefundService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ReturnRefundDTO> GetItem(string trncode, string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ReturnRefundDTO>($"Pos/getreturnproduct/{trncode}/{uid}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> IssueReturnRefund(CreateReturnRefundDTO items)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Pos/posreturn", items);
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
