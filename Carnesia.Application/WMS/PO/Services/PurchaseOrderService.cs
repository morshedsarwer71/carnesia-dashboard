using Carnesia.Domain.Common.ResponseData;
using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.PO.Services
{
    public class PurchaseOrderService : IPurchaseOrder
    {
        private readonly HttpClient _httpClient;
        public PurchaseOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("PurchaseOrders", purchaseOrder);
                //var result = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<Response>(json);
                    return deserialized.Message;
                }
                return "Failed";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
