using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.HRM.User;

namespace Carnesia.Application.HRM.User
{
    public interface IUser
    {
        Task<List<UsersDTO>> GetUsers();
        Task<string[]> GetUsersAsString();
        Task<UsersDTO> GetUserByConcat(string user);
    }
}
