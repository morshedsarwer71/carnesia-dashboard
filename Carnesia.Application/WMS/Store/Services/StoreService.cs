using Carnesia.Domain.WMS.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Carnesia.Application.WMS.Store.Services
{
    public class StoreService : IStore
    {
        private readonly HttpClient _httpClient;
        public StoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
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
    }
}
