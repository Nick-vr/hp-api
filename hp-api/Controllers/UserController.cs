using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace hp_api.Controllers
{
  
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
            // private readonly IUserRepo _userRepo;
            //
            // public UserController(IConfiguration configuration)
            // {
            //     _userRepo = new UserRepo(configuration);
            // }
            // [HttpGet]
            // public async Task<IEnumerable<User>> GetAllUsersAsync()
            // {
            //     return await _userRepo.FindAllAsync();
            // }
            //
            // [HttpGet("{id}")]
            // // [Route("GetUserById/{id:int}")]
            // public async Task<User> GetUserByIdAsync(int id)
            // {
            //     return await _userRepo.FindByIdAsync(id);
            // }
            //
            // [HttpGet("name/{username}")]
            // //[Route("name/{username}")]
            // public async Task<User> GetUserByUserNameAsync(string username)
            // {
            //     return await _userRepo.FindByUserNameAsync(username);
            // }
        }
    
}