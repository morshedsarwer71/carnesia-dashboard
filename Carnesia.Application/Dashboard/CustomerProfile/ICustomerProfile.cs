using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.CustomerProfile;

namespace Carnesia.Application.Dashboard.CustomerProfile
{
    public interface ICustomerProfile
    {
        Task<List<CustomerProfileDTO>> GetCustomers();
        Task<List<CustomerProfileDTO>> GetCustomersBySearch(string searchTearm);

    }
}
