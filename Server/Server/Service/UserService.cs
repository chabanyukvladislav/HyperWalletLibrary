using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Api;
using Server.Database;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Service
{
    public class UserService : IUserService
    {
        private readonly IDatabaseWorker<User> _databaseWorker;
        private readonly IApiWorker<User> _apiWorker;

        public UserService(Context context)
        {
            _databaseWorker = new UserDatabaseWorker(context);
            _apiWorker = new UserApiWorker();
        }

        public async Task<List<User>> Get()
        {
            List<User> list = await _databaseWorker.GetAsync();
            return list;
        }

        public async Task<User> Get(string clientId)
        {
            User user = await _databaseWorker.GetAsync(clientId);
            return user;
        }

        public async Task<bool> Post(User value)
        {
            User user = await _apiWorker.PostAsync(value);
            if (user == null)
                return false;
            bool result = await _databaseWorker.PostAsync(user);
            return result;
        }

        public async Task<bool> Put(string clientId, User value)
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
