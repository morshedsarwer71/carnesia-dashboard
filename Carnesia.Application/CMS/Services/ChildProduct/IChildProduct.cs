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
        Task<string> CreateChildProduct(ChildProductDTO ProductData);
        Task<SingleChildProductDTO> GetChildById(string id);
        Task<string> UpdateChildProduct(ChildProductUpdateDTO childProduct);
        Task DeleteImage(int id);
        Task UpdateImage(UpdateProductImageDTO Images, int id);
        Task<List<ChildProductDetailsDTO>> UploadBulkProducts(InputFileChangeEventArgs e);
        Task<List<BulkImageUploadDTO>> UploadXLSXFileForImage(InputFileChangeEventArgs e);
        Task<string> CreateBulkProducts(List<ChildProductDetailsDTO> products);
        Task<List<BulkImageUploadDTO>> CreateBulkImages(List<BulkImageUploadDTO> Images);
        Task<List<BulkCategoryUploadDTO>> UploadXLSXFileForCategory(InputFileChangeEventArgs e);
        Task<List<BulkCategoryUploadDTO>> CreateBulkCategories(List<BulkCategoryUploadDTO> Categories);
    }
}
