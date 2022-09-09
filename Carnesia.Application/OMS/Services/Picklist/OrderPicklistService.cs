using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.Picklist.CreatePicklist;

namespace Carnesia.Application.OMS.Services.Picklist
{
    public class OrderPicklistService : IOrderPicklist
    {
        private readonly HttpClient _httpClient;
        public OrderPicklistService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PendingOrderDTO>> GetOrders()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/picklistorders");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<PendingOrderDTO>> GetOrdersByFilter(PicklistFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/picklistordersfilter", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
