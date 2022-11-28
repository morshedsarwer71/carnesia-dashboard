using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Campaign;
using Carnesia.Domain.WMS.PO.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.CreateCampaign
{
    public interface ICreateCampaign
    {
        Task<bool> CreateCampaign(AddCampaignDTO Campaign);
        Task<bool> UpdateCampaignDetails(AddCampaignDetailsDTO Campaign, int id);
        Task<bool> AddProductToCampaign(AddCampaignProductDTO Product);
        Task<bool> DeleteCampaignProduct (int id);
        Task<bool> UpdateCampaignProduct (CampaignProductUpdateDTO product, int id);
        Task<List<AddCampaignProductDTO>> UploadXLSXFile(InputFileChangeEventArgs e);
        Task<List<CampaignProductUpdateDTO>> UploadProductUpdateExcelFile(InputFileChangeEventArgs e);
        Task<bool> ProductBulkUpdate(List<CampaignProductUpdateDTO> products, string code);
    }
}
