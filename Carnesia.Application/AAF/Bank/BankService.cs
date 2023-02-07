using Carnesia.Domain.AAF.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.AAF.Bank
{
    public class BankService : IBank
    {
        private readonly HttpClient _httpClient;
        public BankService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CraeteBank(BankDTO bank)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("accounting/addbank", bank);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BankDTO> GetBank(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BankDTO>($"accounting/bank/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BankDTO>> GetBanks()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BankDTO>>("accounting/banks");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBank(BankDTO bank)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"accounting/updatebank/{bank.id}", bank); 
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
