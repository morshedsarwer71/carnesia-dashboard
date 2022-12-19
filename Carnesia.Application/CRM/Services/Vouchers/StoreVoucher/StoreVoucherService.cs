﻿using Carnesia.Domain.CRM.Vouchers.StoreVoucher.CreateStoreVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CRM.Vouchers.StoreVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.StoreVoucher
{
    public class StoreVoucherService : IStoreVoucher
    {
        private readonly HttpClient _httpClient;
        public StoreVoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddNewStore(int id, CreateStoreVoucherStoreDTO storeId)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync($"Voucher/store/newstore/{id}", storeId);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateStoreVoucher(CreateStoreVoucherDTO Voucher)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Voucher/store", Voucher);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteVoucher(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Voucher/store/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteVoucherStore(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"Voucher/store/store/{id}");
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<VoucherListDTO>> GetAllVouchers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<VoucherListDTO>>("Voucher/store");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<VoucherListDTO> GetVoucherById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<VoucherListDTO>($"Voucher/store/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleUse(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync($"Voucher/togglestore/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateVoucher(UpdateStoreVoucherDTO voucher)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Voucher/store/{voucher.id}", voucher);
                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
