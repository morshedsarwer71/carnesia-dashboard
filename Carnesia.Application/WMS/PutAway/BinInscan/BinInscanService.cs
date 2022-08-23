using Carnesia.Domain.WMS.BinInscan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Blazored.LocalStorage;

namespace Carnesia.Application.WMS.PutAway.BinInscan
{
    public class BinInscanService : IBinInscan
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _storage;
        public BinInscanService(HttpClient httpClient, ILocalStorageService storage)
        {
            _httpClient = httpClient;
            _storage = storage;
        }

        public async Task<BinDetailsPoco> GetBinDetails(string bin)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BinDetailsPoco>($"PutAway/bindetails/{bin}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BinInscanDTO> GetSingleBinInscan(string uid, string bin)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BinInscanDTO>($"PutAway/singlebininscan/{uid}/{bin}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
