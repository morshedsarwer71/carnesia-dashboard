using Carnesia.Domain.WMS.Bin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Common.ResponseData;

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
                var result = await _httpClient.PostAsJsonAsync("Bins", bin);
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

        public async Task<List<GetBinDTO>> GetBins()
        {
            try
            {
                //bin = "firstbin";
                var response = await _httpClient.GetFromJsonAsync<List<GetBinDTO>>($"Bins");

                return response;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public async Task<List<GetBinDTO>> GetBinSearch(string bin, int storeId, bool status)
        {
            try
            {
                //bin = "firstbin";
                var response = await _httpClient.GetFromJsonAsync<List<GetBinDTO>>($"Bins/search?storeId={storeId}&binName={bin}&status={status}");
                return response;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public async Task<Response> ChangeStatus(int binId)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<Response>($"Bins/changesbinstatus/{binId}");
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<BinDTO> GetSingleBin(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BinDTO>($"Bins/singlebin/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBin(BinDTO bin)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Bins/{bin.id}", bin);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ReturnImageBase()
        {
            return "https://oshud.com";
        }
    }
}
