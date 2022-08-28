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
				var result = await _httpClient.GetFromJsonAsync<OutScanDTO>("");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
