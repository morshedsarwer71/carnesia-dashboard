using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.OrderDetails;

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
                var result = await _httpClient.PostAsJsonAsync("Oms/assignagent", agent);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CancelOrder(int orderId)
        {
            try
            {
                var result = await _httpClient.GetAsync($"Oms/cancelorder/{orderId}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<AgentDTO>> GetAgents()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<AgentDTO>>("Oms/agent");

                return result;
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
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/pendingorders");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<List<PendingOrderDTO>> GetOrderDetails(OrderDetailsFilterDTO filter)
		{
			try
			{
                var result = await _httpClient.PostAsJsonAsync("Oms/orderdetailsreport", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);
                return data;
			}
			catch (Exception)
			{

				throw;
			}
		}

        public async Task<List<PendingOrderDTO>> GetPendingOrdersByFilter(PendingOrderFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/pendingorderfilter", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> VerifyOrder(int orderId)
        {
            try
            {
                var result = await _httpClient.GetAsync($"Oms/verifyorder/{orderId}");

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
