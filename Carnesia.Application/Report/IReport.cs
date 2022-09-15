using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.UIDReport;

namespace Carnesia.Application.Report
{
    public interface IReport
    {
        Task<List<UIDReportDTO>> GetUIDReportByFilter(UIDReportFilterDTO filter);
    }
}
