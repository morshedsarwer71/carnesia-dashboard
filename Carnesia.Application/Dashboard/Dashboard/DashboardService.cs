using Carnesia.Domain.Dashboard.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.Dashboard.SalesReport;

namespace Carnesia.Application.Dashboard.Dashboard
{
	public class DashboardService : IDashboard
	{
		private readonly HttpClient _httpClient;
		public DashboardService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<SalesReportDTO>> GetMISSalesReport(SalesReportFilterDTO Filter)
		{
			try
			{
				var result = await _httpClient.PostAsJsonAsync("Pos/salesdatareport", Filter);

				var json = await result.Content.ReadAsStringAsync();
				var data = JsonConvert.DeserializeObject<List<SalesReportDTO>>(json);

				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<SalesReportPaymentTypeDTO>> GetSalesPaymentReport(string date, int store)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<SalesReportPaymentTypeDTO>>($"Pos/salesbypaymettype/{date}/{store}");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
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

		public async Task<List<SalesReportDTO>> GetSalesReport(SalesReportFilterDTO Filter)
		{
			try
			{
				var result = await _httpClient.PostAsJsonAsync("Pos/storepossalesdatareport", Filter);

				var json = await result.Content.ReadAsStringAsync();
				var data = JsonConvert.DeserializeObject<List<SalesReportDTO>>(json);

				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
