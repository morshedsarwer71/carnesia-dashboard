using Carnesia.Domain.CMS.CreateToBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.ToBagList;

namespace Carnesia.Application.CMS.Services.ToBag
{
    public class ToBagService : IToBag
    {
        private readonly HttpClient _httpClient;
        public ToBagService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddSingleToBag(AddToBagDTO ToBag)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("ToBag/addtobagtosection", ToBag);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateToBag(NewToBagDTO ToBag)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("ToBag/createtobag", ToBag);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteSection(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"ToBag/deletetobagsection/{id}");
                if(result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteToBag(int id)
        {
            try
            {
                Console.WriteLine(id);
                await _httpClient.DeleteAsync($"ToBag/deletetobag/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ToBagListSectionDTO>> GetAllToBags()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ToBagListSectionDTO>>("ToBag/getalltobag");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UpdateHomeSectionThumbDTO> GetSingleThumb(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<UpdateHomeSectionThumbDTO>($"ToBag/gettobagthumbyid/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PublishToggleSection(int id)
        {
            try
            {
               var result = await _httpClient.GetAsync($"ToBag/toggletobagSection/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task PublishToggleToBag(int id)
        {
            try
            {
                await _httpClient.PostAsync($"ToBag/toggletobag/{id}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleHomePlacement(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"ToBag/toggleHomepagetobag/{id}");

                if (result == "Toggled") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateSection(ToBagListSectionDTO Section)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"ToBag/updatetobagSection/{Section.id}", Section);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateThumb(UpdateHomeSectionThumbDTO thumb)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"ToBag/updatetobag/{thumb.id}", thumb);

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
