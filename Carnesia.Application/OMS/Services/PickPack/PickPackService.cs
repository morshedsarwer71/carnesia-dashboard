using Carnesia.Domain.OMS.PickPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.OMS.Services.PickPack
{
    public class PickPackService : IPickPack
    {
        private readonly HttpClient _httpClient;
        public PickPackService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PickPackDTO> AddUID(string trnCode, string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/pack/{trnCode}/{uid}");

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<PickPackDTO> ConfirmPicklist(string trnCode)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/confirmpack/{trnCode}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PickPackDTO> GetPickPackByTRN(string trnCode)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/pack/{trnCode}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
