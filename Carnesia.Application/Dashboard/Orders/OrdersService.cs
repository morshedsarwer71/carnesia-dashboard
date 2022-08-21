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

        public async Task<List<OrderDTO>> GetOrdersBySearch(string searchTearm)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<OrderDTO>>($"Pos/posorders/{searchTearm}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
