using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.business.Services;
using hp_api.data.Models;
using hp_api.data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace hp_api.Controllers
{
  
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
            private readonly IUserService  _userService;
            
            public UserController(IUserService userService)
            {
                _userService = userService;
            }
            [HttpGet]
            public async Task<IEnumerable<User>> GetAllUsersAsync()
            {
                return await _userService.GetAllUsersAsync();
            }
            
            [HttpGet("{id:int}")]
            public async Task<User> GetUserByIdAsync(int id)
            {
                return await _userService.GetUserByIdAsync(id);
            }
        }
    
}