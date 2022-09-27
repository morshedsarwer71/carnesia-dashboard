using Carnesia.Domain.MIS.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.MIS.Analytics
{
	public class AnalyticsService : IAnalytics
	{
		private readonly HttpClient _httpClient;
		public AnalyticsService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<AnalyticsDTO> GetAnalyticsByFilter(AnalyticsFilterDTO filter)
		{
			try
			{
				var result = await _httpClient.PostAsJsonAsync("Oms/revenuereport", filter);

				var json = await result.Content.ReadAsStringAsync();
				var data = JsonConvert.DeserializeObject<AnalyticsDTO>(json);

				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<AnalyticsDetailsDTO>> GetwebDetailsByDate(string date)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<AnalyticsDetailsDTO>>($"Oms/revenuereportsource/{date}");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
