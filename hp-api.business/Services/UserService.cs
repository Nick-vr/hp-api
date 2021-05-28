using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.data.Models;
using hp_api.data.Repositories;

namespace hp_api.business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo  _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }
        
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetUserByIdAsync(id);
        }
    }
}