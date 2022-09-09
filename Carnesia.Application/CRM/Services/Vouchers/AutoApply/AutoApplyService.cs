using Carnesia.Domain.CRM.Vouchers.AutoApply.CreateVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CRM.Vouchers.AutoApply.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.AutoApply
{
	public class AutoApplyService : IAutoApply
	{
		private readonly HttpClient _httpClient;
		public AutoApplyService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<bool> DeleteVoucher(int id)
		{
			try
			{
				var result = await _httpClient.DeleteAsync($"Voucher/deleteautoapply/{id}");

				if (result.IsSuccessStatusCode) return true;
				return false;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<AutoApplyListDTO>> GetAllAutoApplies()
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<AutoApplyListDTO>>("Voucher/getallautoapply");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<bool> NewAutoApply(AddAutoApplyDTO autoApply)
		{
			try
			{
				var result = await _httpClient.PostAsJsonAsync("Voucher/autoapply", autoApply);

				if (result.IsSuccessStatusCode) return true;
				return false;
			}
			catch (Exception)
			{

				throw;
			}
		}

        public async Task<bool> ToggleUse(int id)
        {
            try
            {
				var result = await _httpClient.GetAsync($"Voucher/autoappltoggle/{id}");

				if (result.IsSuccessStatusCode) return true;
				return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
