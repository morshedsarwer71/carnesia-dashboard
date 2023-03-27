using Carnesia.Domain.WMS.POReport;
using Carnesia.Domain.WMS.UIDReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Report.POReport
{
    public interface IPOReport
    {
        Task<List<POReportDTO>> GetPoReport(POReportFilterDTO filter);
        Task<List<UIDReportDTO>> GetUidReport(UIDReportFilterDTO filter);
    }
}
