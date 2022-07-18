using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Campaign;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.CreateCampaign
{
    public interface ICreateCampaign
    {
        Task CreateCampaign(AddCampaignDTO Campaign);
        Task<bool> UpdateCampaignDetails(AddCampaignDetailsDTO Campaign, int id);
        Task<bool> AddProductToCampaign(AddCampaignProductDTO Product);
        Task<bool> DeleteCampaignProduct (int id);
        Task<List<AddCampaignProductDTO>> UploadXLSXFile(InputFileChangeEventArgs e);
    }
}
