using Carnesia.Domain.OMS.AssignDelivery.Dispatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.PickPack;

namespace Carnesia.Application.OMS.Services.AssignOrder
{
    public class AssignOrderService : IAssignOrder
    {
        private readonly HttpClient _httpClient;
        public AssignOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PickPackDTO> AssignCourier(AssignCourierDTO courierData)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/dispatchorder/{courierData.courierId}/{courierData.carrierName}/{courierData.carrierPhone}/{courierData.trnCode}");

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> CreateCourier(CourierDTO courier)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/courier", courier);
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
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
