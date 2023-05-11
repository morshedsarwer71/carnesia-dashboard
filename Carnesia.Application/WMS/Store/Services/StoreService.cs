using Carnesia.Domain.WMS.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Carnesia.Domain.AAF.Stores;

namespace Carnesia.Application.WMS.Store.Services
{
    public class StoreService : IStore
    {
        private readonly HttpClient _httpClient;
        public StoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CheckVatable()
        {
            try
            {
                var result = await _httpClient.GetStringAsync("Stores/isvatable");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<StoresDTO>> GetAllStores()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<StoresDTO>>("Stores/getstores");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<StoresDTO>> GetAllTracks()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<StoresDTO>>("Stores/vattrack");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<StoreDTO> GetStore(string storeName)
        {
            try
            {
                var stores = await GetStoresAsync();
                return stores.FirstOrDefault(x=>x.storeName==storeName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetStoreNameAsString()
        {
            try
            {
                var list = new List<string>();
                var stores = await GetStoresAsync();
                list.AddRange(stores.Select(x => x.storeName));
                return list.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<StoreDTO>> GetStoresAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<StoreDTO>>("Stores");
                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> ToggleVatable(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"Stores/togglevat/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
