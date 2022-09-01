using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.HomeCarousel;

namespace Carnesia.Application.CMS.Services.HomeCarousel
{
    public interface IHomeCarousel
    {
        Task<List<HomeCarouselDTO>> GetHomeCarousels();

        Task<bool> ToggleCarousel(int carouselID);
        Task AddCarousel(AddHomeCarouselDTO Carousel);

        Task RemoveCarousel(int carouselID);
    }
}
