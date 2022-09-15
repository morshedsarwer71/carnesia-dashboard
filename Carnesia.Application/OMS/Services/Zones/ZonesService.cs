using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.Zones;

namespace Carnesia.Application.OMS.Services.Zones
{
    public class ZonesService : IZones
    {
        private readonly HttpClient _httpClient;
        public ZonesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> CreateCustomerAddress(CustomerDeliveryAddressDTO customerAddress)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("DeliveryAddress/addaddress", customerAddress);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<int>(json);

                return data;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task CreateDistrict(AddDistrictDTO District)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Oms/district/new", District);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateZone(AddZoneDTO Zone)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Oms/zone/new", Zone);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CustomerDeliveryAddressGetDTO> GetCustomerDeliveryAddress(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<CustomerDeliveryAddressGetDTO>($"DeliveryAddress/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<DivisionDTO>> GetDivisions()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<DivisionDTO>>("Oms/deliveryaddress");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ZoneDTO> GetZoneById(int zoneId)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ZoneDTO>($"Oms/zone/{zoneId}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ZoneDTO>> GetZones()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ZoneDTO>>("Oms/zone");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateDistrict(AddDistrictDTO District, int id)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Oms/UpdateDistrict/{id}", District);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateZone(AddZoneDTO Zone, int id)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Oms/UpdateZone/{id}", Zone);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
