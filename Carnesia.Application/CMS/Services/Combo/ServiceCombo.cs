using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Carnesia.Domain.CMS.ComboProducts;

namespace Carnesia.Application.CMS.Services.Combo
{
    public class ServiceCombo : ICombo
    {
        private readonly HttpClient _httpClient;
        public ServiceCombo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateCombo(AddComboDTO combo)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("ComboProduct", combo);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ComboListDTO> GetComboById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ComboListDTO>($"ComboProduct/{id}");

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ComboListDTO>> GetAllCombos()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ComboListDTO>>("ComboProduct");

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> RemoveProduct(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"ComboProduct/deleteComboProductTag/{id}");

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> AddProduct(AddComboProductDTO product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("ComboProduct/addComboProductTag", product);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateCombo(ComboListDTO combo)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"ComboProduct/{combo.comboId}", combo);

                if(result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
