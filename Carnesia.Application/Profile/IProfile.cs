using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Profile;

namespace Carnesia.Application.Profile
{
    public interface IProfile
    {
        //Task<List<ProfileDTO>> GetProfile();
        Task<ProfileDTO> GetProfile();
        Task<bool> ChagePassword(ChangePasswordDTO password);
    }
}
