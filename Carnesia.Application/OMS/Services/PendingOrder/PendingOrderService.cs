using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.OMS.Services.PendingOrder
{
    public class PendingOrderService : IPendingOrder
    {
        private readonly HttpClient _httpClient;
        public PendingOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AssignAgent(AssignAgentDTO agent)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Order/assignagent", agent);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PendingOrderDTO>> GetAllPendingOrders()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Order/pendingorders");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
