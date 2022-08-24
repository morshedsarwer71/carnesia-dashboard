using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.HRM.PanelUser;

namespace Carnesia.Application.HRM.PanelUser
{
    public interface IPanelUser
    {
        Task<string[]> GetRoles();
        Task<bool> NewPanelUser(PanelUserDTO user);
        Task<List<PanelUserListDTO>> GetUsers();
    }
}
