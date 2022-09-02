using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.Dashboard;

namespace Carnesia.Application.Dashboard.Dashboard
{
	public interface IDashboard
	{
		Task<List<DashboardDTO>> GetSalesReport(string fromDate, string toDate, int store);
	}
}
