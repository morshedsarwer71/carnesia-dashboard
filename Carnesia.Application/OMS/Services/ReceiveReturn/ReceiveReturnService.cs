using Carnesia.Domain.OMS.PickPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.ReturnManagement.PendingReturn;

namespace Carnesia.Application.OMS.Services.ReceiveReturn
{
	public class ReceiveReturnService : IReceiveReturn
	{
		private readonly HttpClient _httpClient;
		public ReceiveReturnService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<PickPackDTO> GetOrderDetails(string orderId)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/return/{orderId}");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

        public async Task<List<PendingReturnDTO>> GetPendingReturns()
        {
            try
            {
				var result = await _httpClient.GetFromJsonAsync<List<PendingReturnDTO>>("Oms/pendingreturns");
				return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PendingReturnDTO>> GetPendingReturnsByFilter(PendingReturnsFilterDTO filter)
        {
            try
            {
				var result = await _httpClient.PostAsJsonAsync("Oms/getpendingreturns", filter);

				var json = await result.Content.ReadAsStringAsync();
				var data = JsonConvert.DeserializeObject<List<PendingReturnDTO>>(json);
				return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PickPackDTO> ReturnItem(string orderId, string uid, bool returnType)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/return/{orderId}/{uid}");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
