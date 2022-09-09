using Carnesia.Domain.OMS.AssignDelivery.Dispatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.OMS.Services.AssignOrder
{
    public class AssignOrderService : IAssignOrder
    {
        private readonly HttpClient _httpClient;
        public AssignOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CourierDTO>> GetCouriers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CourierDTO>>("Oms/couriers");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
