using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.BunchProduct;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.BunchProduct
{
    public interface IBunchProduct
    {
        Task<bool> CreateBunchProduct(AddBunchProductDTO bunch);
        Task<List<BunchProductDTO>> GetBunchProducts();
        Task<SingleBunchProductDTO> GetBunchById(int id);
        Task<bool> AddNewProduct(AddBunchProductProductsDTO product);
        Task<bool> DeleteProduct(int id);
        Task<bool> UpdateBunch(SingleBunchProductDTO bunch);
        Task<bool> DeleteBunch(int id);
        Task<bool> ToggleBunchProduct(int id);
        Task<List<AddBunchProductProductsDTO>> UploadXLSXFile(InputFileChangeEventArgs e);
    }
}
