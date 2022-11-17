﻿using Carnesia.Domain.WMS.Initiate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.WMS.Projects;

namespace Carnesia.Application.WMS.Projects
{
    public class ProjectsService : IProjects
    {
        private readonly HttpClient _httpClient;
        public ProjectsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProjectsDetailsHeadDTO> AddProductToBinDetails(string pCode, string bin, string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/binaudit/{bin}/{pCode}/{uid}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<ProjectsDetailsHeadDTO> AddProductToPoDetails(string pCode, string po, string uid, string bin)
		{
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/poaudit/{po}/{bin}/{pCode}/{uid}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<ProjectsDetailsHeadDTO> AddProductToSkuDetails(string pCode, string sku, string uid)
		{
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/skuaudit/{sku}/{pCode}/{uid}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<string> CompleteBinProject(string pCode, string bin)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"cyclecount/completebinaudit/{bin}/{pCode}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<string> CompletePoProject(string pCode, string po)
		{
            try
            {
                var result = await _httpClient.GetStringAsync($"cyclecount/completepoaudit/{po}/{pCode}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<bool> CompleteProject(string projectId)
		{
			try
			{
                var result = await _httpClient.GetAsync($"cyclecount/closeproject/{projectId}");
                return result.IsSuccessStatusCode;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<string> CompleteSkuProject(string pCode, string sku)
		{
            try
            {
                var result = await _httpClient.GetStringAsync($"cyclecount/completeskuaudit/{sku}/{pCode}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<List<ProjectsDTO>> GetAllProjects()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProjectsDTO>>("cyclecount/getprojects");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProjectsDetailsHeadDTO> GetBinDetails(string pCode, string bin)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/binaudit/{bin}/{pCode}");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

		public async Task<ProjectsDetailsHeadDTO> GetPoDetails(string pCode, string po)
		{
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/poaudit/{po}/{pCode}");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

		public async Task<ProjectsDetailsHeadDTO> GetSkuDetails(string pCode, string sku)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProjectsDetailsHeadDTO>($"cyclecount/skuaudit/{sku}/{pCode}");
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> NewProjects(InitiateDTO initiate)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("cyclecount/createproject", initiate);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateProject(UpdateProjectDTO project)
        {
            try
            {
                var result = await _httpClient.GetAsync($"cyclecount/changeprojecttype/{project.id}/{project.projectType}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}