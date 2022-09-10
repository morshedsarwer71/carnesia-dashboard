using Carnesia.Domain.OMS.PickPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

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
	}
}
