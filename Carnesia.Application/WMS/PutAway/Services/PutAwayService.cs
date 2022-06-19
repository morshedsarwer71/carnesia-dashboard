﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.BinInscan;
using Carnesia.Application.WMS.PutAway.Poco;

namespace Carnesia.Application.WMS.PutAway.Services
{
    public class PutAwayService : IPutAway
    {
        private readonly HttpClient _httpClient;
        public PutAwayService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UIDHistoryPoco> GetUIDHistory(string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<UIDHistoryPoco>($"PutAway/trackuid/{uid}");
                if (result == null)
                    return null;
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BinInscanDTO> SingleBinInscan(string uid, string binNumber)
        {
            try
            {
                var result =await _httpClient.GetFromJsonAsync<BinInscanDTO>($"PutAway/singlebininscan/{uid}/{binNumber}");
                if (result == null)
                    return null;
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
