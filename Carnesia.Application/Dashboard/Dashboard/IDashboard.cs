using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.Dashboard;
using Carnesia.Domain.Dashboard.SalesReport;

namespace Carnesia.Application.Dashboard.Dashboard
{
	public interface IDashboard
	{
		Task<List<DashboardDTO>> GetSalesReport(string fromDate, string toDate, int store);
		Task<List<SalesReportDTO>> GetSalesReport(SalesReportFilterDTO Filter);
		Task<List<SalesReportDTO>> GetMISSalesReport(SalesReportFilterDTO Filter);
		Task<List<SalesReportPaymentTypeDTO>> GetSalesPaymentReport(string date, int store);
	}
}
