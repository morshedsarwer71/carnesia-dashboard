using Carnesia.Domain.CMS.HomeCarousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Carnesia.Application.CMS.Services.HomeCarousel
{
    public class HomeCarouselService : IHomeCarousel
    {
        private readonly HttpClient _httpClient;
        public HomeCarouselService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddCarousel(AddHomeCarouselDTO Carousel)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("HomePage/homecarousalimages", Carousel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<HomeCarouselDTO>> GetHomeCarousels()
        {
            try
            {
                var Carousel = await _httpClient.GetFromJsonAsync<List<HomeCarouselDTO>>("HomePage/getallcarousalimages");

                return Carousel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RemoveCarousel(int carouselID)
        {
            try
            {
                await _httpClient.DeleteAsync($"HomePage/deletecarousalimage/{carouselID}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task ToggleCarousel(int carouselID)
        {
            try
            {
                await _httpClient.PostAsync($"HomePage/togglepublishcarousalimage/{carouselID}", null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
