using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.data.Models;

namespace hp_api.data.Repositories
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync(string sql);
        Task<User> GetByIdAsync(int id, string sql);
    }
}