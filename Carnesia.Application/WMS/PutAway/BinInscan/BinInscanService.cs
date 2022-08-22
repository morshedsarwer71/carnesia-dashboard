using Carnesia.Domain.WMS.BinInscan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.WMS.PutAway.BinInscan
{
    public class BinInscanService : IBinInscan
    {
        private readonly HttpClient _httpClient;
        public BinInscanService(HttpClient httpClient)
        {
            _httpClient = httpClient;
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
