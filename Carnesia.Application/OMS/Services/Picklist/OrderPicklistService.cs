using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.Picklist.CreatePicklist;
using Carnesia.Domain.OMS.PickPack;
using Carnesia.Domain.OMS.Picklist.GeneratedPicklist;

namespace Carnesia.Application.OMS.Services.Picklist
{
    public class OrderPicklistService : IOrderPicklist
    {
        private readonly HttpClient _httpClient;
        public OrderPicklistService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PickPackDTO> GeneratePicklist(List<PickListGenerateDTO> orderIDS)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/generatepicklist", orderIDS);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<PickPackDTO>(json);
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<List<GeneratedPicklistDTO>> GetGeneratedPiclist()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<GeneratedPicklistDTO>>("Oms/picklistedorders");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
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

        public async Task<PickPackDTO> RemoveOrderFromPicklist(RemoveFromPicklistDTO order)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/returnorderfrompicklist", order);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<PickPackDTO>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
