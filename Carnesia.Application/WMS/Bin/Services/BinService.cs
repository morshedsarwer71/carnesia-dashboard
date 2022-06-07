using Carnesia.Domain.WMS.Bin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Bin.Services
{
    public class BinService : IBin
    {
        private readonly HttpClient _httpClient;
        public BinService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<BinDTO> AddBin(BinDTO bin)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Bin", bin);
                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var convet = JsonConvert.DeserializeObject<BinDTO>(json);
                    return convet;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public async Task<List<GetBinDTO>> GetBins(string? bin, int storeId, bool status)
        {
            try
            {
                //bin = "firstbin";
                var response =await _httpClient.GetFromJsonAsync<List<GetBinDTO>>($"Bin?storeId={storeId}&binName={bin}&status={status}");
                /*var response = await _httpClient.GetAsync($"Bin?storeId={0}&binName={bin}&status={true}");
                if (response.IsSuccessStatusCode)
                {
                    var json =  await response.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                    var convert = JsonConvert.DeserializeObject<List<GetBinDTO>>(json);
                    return convert;
                };*/
                return response;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
