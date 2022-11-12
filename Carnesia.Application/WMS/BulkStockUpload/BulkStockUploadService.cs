using Carnesia.Domain.WMS.BulkStockUpload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.WMS.BulkStockUpload
{
    public class BulkStockUploadService : IBulkStockUpload
    {
        private readonly HttpClient _httpClient;
        public BulkStockUploadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FilterStockProductDTO>> GetProducts(StockFilterDTO stockFilter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("wmsreport/restockfilter", stockFilter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<FilterStockProductDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateStock(StockFilterDTO stockFilter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("wmsreport/restock", stockFilter);

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
