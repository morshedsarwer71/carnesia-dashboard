using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ChildProduct;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.ChildProduct
{
    public interface IChildProduct
    {
        Task CreateChildProduct(ChildProductDTO ProductData);
        Task<SingleChildProductDTO> GetChildById(int id);
        Task UpdateChildProduct(ChildProductUpdateDTO childProduct);
        Task DeleteImage(int id);
        Task UpdateImage(UpdateProductImageDTO Images, int id);
        Task<List<ChildProductDetailsDTO>> UploadBulkProducts(InputFileChangeEventArgs e);
        Task<List<BulkImageUploadDTO>> UploadXLSXFileForImage(InputFileChangeEventArgs e);
        Task<string> CreateBulkProducts(List<ChildProductDetailsDTO> products);
    }
}
