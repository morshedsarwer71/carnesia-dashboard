﻿using Carnesia.Domain.WMS.ManageTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Carnesia.Domain.WMS.OutScan;
using Carnesia.Domain.WMS.ReceiveTo;
using Carnesia.Domain.WMS.UpdateTO;

namespace Carnesia.Application.WMS.StockTransfer.ManageTo
{
    public class ManageToService : IManageTo
	{
		private readonly HttpClient _httpClient;
		public ManageToService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<string> Acknowledgement(string toid)
		{
			try
			{
				var result = await _httpClient.GetStringAsync($"StockTransfers/confirmreceiveto/{toid}");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task CancelPicklist(string pickList)
        {
            try
            {
				var result = await _httpClient.GetAsync($"StockTransfers/cancelgeneratepicklist/{pickList}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ConfirmPickList(string picklistID)
        {
            try
            {
				var result = await _httpClient.GetAsync($"StockTransfers/confirmpicklist/{picklistID}");

				if (result.IsSuccessStatusCode) return true;
				return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteToProducts(DeleteToProductsDTO products)
        {
            try
            {
				var result = await _httpClient.PostAsJsonAsync("StockTransfers/removetoproduct", products);

				if (result.IsSuccessStatusCode) return true;
				return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task GeneratePicklistID(string trnCode)
		{
			try
			{
				var result = await _httpClient.GetAsync($"StockTransfers/generatepicklist/{trnCode}");
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<ManageToDTO>> GetAllManageTo()
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<List<ManageToDTO>>("StockTransfers");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<OutUIDScanDTO> GetOutScan(string picklistID, string uid)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<OutUIDScanDTO>($"StockTransfers/outscan/{picklistID}/{uid}");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

        public async Task<List<NewOutScanProductDTO>> GetProductsByPickList(string picklistID)
        {
            try
            {
				var result = await _httpClient.GetFromJsonAsync<List<NewOutScanProductDTO>>($"StockTransfers/getpicklistbycode/{picklistID}");

				return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UpdateTODTO> GetToDetails(string toid)
        {
            try
            {
				var result = await _httpClient.GetFromJsonAsync<UpdateTODTO>($"StockTransfers/getstocktransfer/{toid}");

				return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ReceiveToDTO> ReceiveToByToid(string toid)
        {
			try
			{
				var result = await _httpClient.GetFromJsonAsync<ReceiveToDTO>($"StockTransfers/receivetobytocode/{toid}");
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<ReceiveToDTO> ReceiveToByUID(string toid, string uid)
		{
			try
			{
				var result = await _httpClient.GetFromJsonAsync<ReceiveToDTO>($"StockTransfers/receiveto/{toid}/{uid}");

				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<bool> UpdateToProductQuantity(string toid, int qty, int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"StockTransfers/updatetoproduct/{toid}/{qty}/{id}");

                if (result == "Product Updated") return true;
                return false;
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
