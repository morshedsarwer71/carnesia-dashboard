using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ComboProducts;

namespace Carnesia.Application.CMS.Services.Combo
{
    public interface ICombo
    {
        Task<bool> CreateCombo(AddComboDTO combo);
        Task<List<ComboListDTO>> GetAllCombos(string BcType);
        Task<ComboListDTO> GetComboById(int id);
        Task<bool> RemoveProduct(int id);
        Task<bool> AddProduct(AddComboProductDTO product);
        Task<bool> UpdateCombo(ComboListDTO combo);
        Task<List<CombosInTimeDTO>> GetCombosInTime();
        Task<bool> CreateNewBogoComboBanner(CreateBogoComboBannerDTO banner);
        Task<List<BogoComboBannerDTO>> GetAllBanners();
        Task<string> ToggleBannerPublish(int Id);
        Task<string> ToggleBannerHome(int Id);
        Task<bool> DeleteBanner(int Id);
    }
}
