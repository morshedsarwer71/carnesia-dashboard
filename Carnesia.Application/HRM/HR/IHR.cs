using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.HRM.HR;

namespace Carnesia.Application.HRM.HR
{
    public interface IHR
    {
        Task<List<HRDepartmentsDTO>> GetDepartments();
        Task<List<HRDesignationsDTO>> GetDesignations();
    }
}
