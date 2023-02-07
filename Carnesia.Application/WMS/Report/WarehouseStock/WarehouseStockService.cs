using Carnesia.Domain.MIS.Analytics;
using Carnesia.Domain.WMS.AllWarehouseStock;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Report.WarehouseStock
{
    public class WarehouseStockService : IWarehouseStock
    {
        private readonly HttpClient _httpClient;
        public WarehouseStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AllwarehouseStockDTO>> GetWarehouseStock(AllWarehouseStockFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/warehousestockreport", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<AllwarehouseStockDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
