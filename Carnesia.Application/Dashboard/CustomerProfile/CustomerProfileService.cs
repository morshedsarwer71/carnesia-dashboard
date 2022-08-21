using Carnesia.Domain.Dashboard.CustomerProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.Dashboard.CustomerProfile
{
    public class CustomerProfileService : ICustomerProfile
    {
        private readonly HttpClient _httpClient;
        public CustomerProfileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CustomerProfileDTO>> GetCustomers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CustomerProfileDTO>>("Pos/poscustomer");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CustomerProfileDTO>> GetCustomersBySearch(string searchTearm)
        {
            var result = await _httpClient.GetFromJsonAsync<List<CustomerProfileDTO>>($"Pos/poscustomer/{searchTearm}");

            return result;
        }
    }
}
