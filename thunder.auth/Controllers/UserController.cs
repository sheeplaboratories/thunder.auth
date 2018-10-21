using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using thunder.auth.Data;

namespace thunder.auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _dbContext;
        public UserController(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var users = new List<UserDTO>();
            foreach(var user in _dbContext.Users.ToList())
            {
                users.Add(new UserDTO
                {
                    userId = user.Id,
                    userEmail = user.Email
                });
            }
            return Ok(users);
        }

    }

    public class UserDTO
    {
        public string userId { get; set; }
        public string userEmail { get; set; }
    }
}