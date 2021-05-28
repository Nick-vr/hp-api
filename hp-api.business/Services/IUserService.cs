using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.data.Models;

namespace hp_api.business.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}