using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Campaign;

namespace Carnesia.Application.CMS.Services.CreateCampaign
{
    public interface ICreateCampaign
    {
        Task CreateCampaign(AddCampaignDTO Campaign);
    }
}
