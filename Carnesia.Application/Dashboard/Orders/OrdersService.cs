using Carnesia.Domain.Dashboard.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.Dashboard.Orders
{
    public class OrdersService : IOrders
    {
        private readonly HttpClient _httpClient;
        public OrdersService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrderDTO>> GetOrders()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<OrderDTO>>("Pos/posorders");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<OrderDTO>> GetOrdersBySearch(OrderFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Pos/posordersfilter", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<OrderDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
