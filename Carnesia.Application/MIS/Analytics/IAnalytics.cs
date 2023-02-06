using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.MIS.Analytics;

namespace Carnesia.Application.MIS.Analytics
{
	public interface IAnalytics
	{
		Task<AnalyticsDTO> GetAnalyticsByFilter(AnalyticsFilterDTO filter);
		Task<AnalyticsDTO> GetProductReportByFilter(AnalyticsFilterDTO filter);
		Task<List<AnalyticsDetailsDTO>> GetwebDetailsByDate(string date);
	}
}
