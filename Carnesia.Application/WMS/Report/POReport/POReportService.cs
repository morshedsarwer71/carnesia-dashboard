using Carnesia.Domain.WMS.AllWarehouseStock;
using Carnesia.Domain.WMS.POReport;
using Carnesia.Domain.WMS.UIDReport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Report.POReport
{
    public class POReportService : IPOReport
    {
        private readonly HttpClient _httpClient;
        public POReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<POReportDTO>> GetPoReport(POReportFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("wmsreport/poreport", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<POReportDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<UIDReportDTO>> GetUidReport(UIDReportFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("wmsreport/uidreport", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<UIDReportDTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
