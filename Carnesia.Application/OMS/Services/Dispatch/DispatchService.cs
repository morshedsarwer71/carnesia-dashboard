﻿using Carnesia.Domain.OMS.AssignDelivery.Dispatch;
using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.PickPack;

namespace Carnesia.Application.OMS.Services.Dispatch
{
    public class DispatchService : IDispatch
    {
        private readonly HttpClient _httpClient;
        public DispatchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AssignCourier(CreateDispatchDTO dispatchData)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/dispatch", dispatchData);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<PickPackDTO> CancelDispatch(string orderId)
		{
			try
			{
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/returndelivery/{orderId}");

                return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<PickPackDTO> ConfirmDispatch(string orderId)
		{
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/confirmdelivery/{orderId}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<List<PendingOrderDTO>> GetDispatchedOrders()
		{
			try
			{
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/dispatchedorders");

                return result;
            }
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<PendingOrderDTO>> GetOrders()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/dispatchorders");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PendingOrderDTO>> GetOrdersByFilter(DispatchFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/dispatchordersfilter", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
