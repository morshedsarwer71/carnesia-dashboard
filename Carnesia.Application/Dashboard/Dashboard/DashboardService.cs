using Carnesia.Domain.Dashboard.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.Dashboard.Dashboard
{
	public class DashboardService : IDashboard
	{
		private readonly HttpClient _httpClient;
		public DashboardService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<List<DashboardDTO>> GetSalesReport(string fromDate, string toDate, int store)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<DashboardDTO>>($"Pos/salesdata/{fromDate}/{toDate}/{store}");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
