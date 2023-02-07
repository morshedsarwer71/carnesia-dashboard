using Carnesia.Domain.OMS.ClosedOrder;
using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.OMS.Services.ClosedOrder
{
    public class ClosedOrderService : IClosedOrder
    {
        private readonly HttpClient _httpClient;
        public ClosedOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PendingOrderDTO>> GetClosedOrders(ClosedOrderFilterDTO orderFilter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/closedorders", orderFilter);

                var json = await result.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);

                return deserialized;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> AssignAgent(AssignAgentDTO agent)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/assignclosedorders", agent);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<bool> TakeFeedBack(CustomerFeedbackDTO feedback)
		{
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/customerfeedback", feedback);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
		}
	}
}
