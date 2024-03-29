﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CRM.Vouchers.ProductVoucher.CreateVoucher;
using Carnesia.Domain.CRM.Vouchers.ProductVoucher.VoucherList;

namespace Carnesia.Application.CRM.Services.Vouchers.ProductVoucher
{
    public class ProductVoucherService : IProductVoucher
    {
        private readonly HttpClient _httpClient;
        public ProductVoucherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateVoucher(CreateProductVoucherDTO Voucher)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Voucher/products", Voucher);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductVoucherListDTO>> GetAllVouchers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductVoucherListDTO>>("Voucher/products");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task RemoveVoucher(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Voucher/products/{id}");
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
                var result = await _httpClient.GetAsync($"Voucher/toggleproduct/{id}");

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
