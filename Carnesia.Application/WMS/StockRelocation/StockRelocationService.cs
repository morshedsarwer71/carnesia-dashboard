using Carnesia.Domain.WMS.BinTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Carnesia.Application.WMS.StockRelocation
{
    public class StockRelocationService : IStockRelocation
    {
        private readonly HttpClient _httpClient;
        public StockRelocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<BinTransferDTO> RelocateProduct(string bin, string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BinTransferDTO>($"PutAway/stockrelocation/{uid}/{bin}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
