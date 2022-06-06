﻿using Carnesia.Domain.CMS.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.Brand
{
    public class BrandService : IBrand
    {
        private readonly HttpClient _httpClient;
        public BrandService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateBrand(CreateBrandDTO NewBrand)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Brands", NewBrand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BrandDTO> GetBrand(string BrandName)
        {
            try
            {
                var brands = await GetBrands();
                return brands.FirstOrDefault(x => x.name == BrandName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BrandDTO>> GetBrands()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BrandDTO>>("Brands");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetBrandsNameAsString()
        {
            try
            {
                var list = new List<string>();
                var brands = await GetBrands();
                list.AddRange(brands.Select(x=>x.name));
                return list.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateBrand(CreateBrandDTO NewBrand, int BrandId)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Brands/{BrandId}", NewBrand);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}