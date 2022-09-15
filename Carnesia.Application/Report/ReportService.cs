using Carnesia.Domain.WMS.UIDReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.Report
{
    public class ReportService : IReport
    {
        private readonly HttpClient _httpClient;
        public ReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<UIDReportDTO>> GetUIDReportByFilter(UIDReportFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("wmsreport/uidreport", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<UIDReportDTO>>(json);
                return (List<UIDReportDTO>)data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
