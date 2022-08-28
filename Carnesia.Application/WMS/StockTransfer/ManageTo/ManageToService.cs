using Carnesia.Domain.WMS.ManageTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Carnesia.Domain.WMS.OutScan;

namespace Carnesia.Application.WMS.StockTransfer.ManageTo
{
	public class ManageToService : IManageTo
	{
		private readonly HttpClient _httpClient;
		public ManageToService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task GeneratePicklistID(string trnCode)
		{
			try
			{
				var result = await _httpClient.GetAsync($"StockTransfers/generatepicklist/{trnCode}");
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<ManageToDTO>> GetAllManageTo()
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<ManageToDTO>>("StockTransfers");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<OutScanDTO> GetOutScan(string picklistID, string uid)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<OutScanDTO>($"StockTransfers/outscan/{picklistID}/{uid}");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
