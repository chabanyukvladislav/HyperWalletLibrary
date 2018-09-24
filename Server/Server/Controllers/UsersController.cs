using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Api;
using Server.Database;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IDatabaseWorker<User> _databaseWorker;
        private readonly IApiWorker<User> _apiWorker;

        public UsersController(Context context)
        {
            _databaseWorker = new UserDatabaseWorker(context);
            _apiWorker = new UserApiWorker();
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            List<User> list = await _databaseWorker.GetAsync();
            return list;
        }

        [HttpGet("{token}")]
        public async Task<User> Get(string clientId)
        {
            User user = await _databaseWorker.GetAsync(clientId);
            return user;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] User value)
        {
            User user = await _apiWorker.PostAsync(value);
            if (user == null)
                return false;
            bool result = await _databaseWorker.PostAsync(user);
            return result;
        }

        [HttpPut("{token}")]
        public async Task<bool> Put(string clientId, [FromBody] User value)
        {
            User data = await _databaseWorker.GetAsync(clientId);
            User user = await _apiWorker.PutAsync(data.Token, value);
            if (user == null)
                return false;
            bool result = await _databaseWorker.PutAsync(clientId, user);
            return result;
        }
    }
}
