using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.MIS.Analytics;
using Carnesia.Domain.MIS.ProcurmentReport;

namespace Carnesia.Application.MIS.Analytics
{
	public interface IAnalytics
	{
		Task<AnalyticsDTO> GetAnalyticsByFilter(AnalyticsFilterDTO filter);
		Task<List<AnalyticsDetailsDTO>> GetwebDetailsByDate(string date);
		Task<List<ProcurmentReportDTO>> GetProcurmentByFilter(ProcurmentReportFilterDTO filter);
		Task<List<ProcurmentReportPoDetailsDTO>> GetProcurmentByFilter(ProcurmentReportPoDetailsParamDTO filter);
		Task<AnalyticsDTO> GetProductReportByFilter(AnalyticsFilterDTO filter);
	}
}
