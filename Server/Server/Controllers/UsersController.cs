using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using Server.Service;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(Context context)
        {
            _service = new UserService(context);
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await _service.Get();
        }

        [HttpGet("{token}")]
        public async Task<User> Get(string clientId)
        {
            return await _service.Get(clientId);
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] User value)
        {
            return await _service.Post(value);
        }

        [HttpPut("{token}")]
        public async Task<bool> Put(string clientId, [FromBody] User value)
        {
            return await _service.Put(clientId, value);
        }
    }
}
