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
                var result = await _httpClient.GetFromJsonAsync<ReceivePODTO>($"PurchaseOrders/approvedpodetails/{poid}");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ReceivePODTO> ReceivedPoByCode(string poid)
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

        public async Task<ReceivePOProductDTO> SubmitReceive(ReceivePOProductDTO PO)
        {
            try
            {
                var res = await _httpClient.PostAsJsonAsync("PurchaseOrders/poreceive", PO);
                if (res.IsSuccessStatusCode)
                {
                    return PO;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
