using Carnesia.Domain.WMS.Initiate;
using Carnesia.Domain.WMS.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Projects
{
    public interface IProjects
    {
        Task<bool> NewProjects(InitiateDTO initiate);
        Task<List<ProjectsDTO>> GetAllProjects();
        Task<bool> UpdateProject(UpdateProjectDTO project);
        Task<ProjectsDetailsHeadDTO> CompleteProject(string projectId);

        Task<ProjectsDetailsHeadDTO> GetBinDetails(string pCode, string bin);
        Task<ProjectsDetailsHeadDTO> GetSkuDetails(string pCode, string sku);
        Task<ProjectsDetailsHeadDTO> GetPoDetails(string pCode, string po);

        Task<ProjectsDetailsHeadDTO> AddProductToBinDetails(string pCode, string bin, string uid);
        Task<ProjectsDetailsHeadDTO> AddProductToSkuDetails(string pCode, string sku, string uid, string bin);
        Task<ProjectsDetailsHeadDTO> AddProductToPoDetails(string pCode, string po, string uid, string bin);

        Task<string> CompleteBinProject (string pCode, string bin);
        Task<string> CompleteSkuProject (string pCode, string sku, string bin);
        Task<string> CompletePoProject (string pCode, string po);

        Task<ProjectsDetailsHeadDTO> GetBinDetailsBySKU(string pCode, string sku, string bin);
    }
}
