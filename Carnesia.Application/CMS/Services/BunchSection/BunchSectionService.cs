using Carnesia.Domain.CMS.BunchSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.BunchSection
{
    public class BunchSectionService : IBunchSection
    {
        private readonly HttpClient _httpClient;
        public BunchSectionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateNewBunchSection(NewBunchSectionDTO bunch)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("HomeBunch/createhomebunch", bunch);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteBunchSection(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"HomeBunch/deletehomebunch/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BunchSectionListDTO>> GetAllBunchSections()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BunchSectionListDTO>>("HomeBunch/getallhomebunch");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BunchThumDTO> GetBunchThumb(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BunchThumDTO>($"HomeBunch/getbunchthums/{id}");

                return result;
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
                var result = await _httpClient.GetStringAsync($"HomeBunch/togglehomepagehomebunch/{id}");

                if (result == "Toggled") return true;
                else return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> TogglePublish(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"HomeBunch/togglepublishhomebunch/{id}");

                if (result == "Toggled") return true;
                else return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateThumb(BunchThumDTO thumb)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"HomeBunch/updatebunchthums/{thumb.id}", thumb);

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
