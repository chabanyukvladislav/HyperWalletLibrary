using Server.Database.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Service
{
    public interface IUserService
    {
        Task<List<User>> Get();
        Task<User> Get(string clientId);
        Task<bool> Post(User value);
        Task<bool> Put(string clientId, User value);
    }
}
