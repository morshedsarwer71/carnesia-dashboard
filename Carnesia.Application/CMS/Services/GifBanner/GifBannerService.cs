using Carnesia.Domain.CMS.GifBanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Carnesia.Application.CMS.Services.GifBanner
{
    public class GifBannerService : IGifBanner
    {
        private readonly HttpClient _httpClient;
        public GifBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<GifBannerDTO>> GetGifBanners()
        {
            try
            {
                var Banners = await _httpClient.GetFromJsonAsync<List<GifBannerDTO>>("HomePage/getallgifbanner");

                return Banners;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
