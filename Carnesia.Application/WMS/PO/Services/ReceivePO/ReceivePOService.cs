using Carnesia.Domain.WMS.PO.ReceivePO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.WMS.PO.Services.ReceivePO
{
    public class ReceivePOService : IReceivePO
    {
        private readonly HttpClient _httpClient;
        public ReceivePOService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ReceivePODTO> GetPO(string poid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ReceivePODTO>($"PurchaseOrders/receivedpobycode/{poid}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task SubmitReceive(ReceivePOProductDTO PO)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("PurchaseOrders/poreceive", PO);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
