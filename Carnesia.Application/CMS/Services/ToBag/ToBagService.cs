﻿using Carnesia.Domain.CMS.CreateToBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.ToBagList;

namespace Carnesia.Application.CMS.Services.ToBag
{
    public class ToBagService : IToBag
    {
        private readonly HttpClient _httpClient;
        public ToBagService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateToBag(NewToBagDTO ToBag)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("ToBag/createtobag", ToBag);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteSection(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"ToBag/deletetobagsection/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteToBag(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"ToBag/deletetobag/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ToBagListSectionDTO>> GetAllToBags()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ToBagListSectionDTO>>("ToBag/getalltobag");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task PublishToggleSection(int id)
        {
            try
            {
                await _httpClient.PostAsync($"ToBag/toggletobagSection/{id}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task PublishToggleToBag(int id)
        {
            try
            {
                await _httpClient.PostAsync($"ToBag/toggletobag/{id}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
