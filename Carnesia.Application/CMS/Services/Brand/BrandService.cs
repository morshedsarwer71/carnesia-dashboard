using Carnesia.Domain.CMS.Brand;
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

        public async Task<CreateBrandDTO> GetBrandById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<CreateBrandDTO>($"Brands/{id}");

                if (result == null)
                {
                    return null;
                }

                return result;
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

        public async Task ToggleBrand(int id)
        {
            try
            {
                await _httpClient.PostAsync($"Brands/Toggle/{id}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleTopBrands(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"Brands/ToggleTopBrand/{id}");

                if (result == "Toggled") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateBrand(CreateBrandDTO Brand)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Brands/{Brand.brandId}", Brand);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
