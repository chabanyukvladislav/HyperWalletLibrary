using Server.Database.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Service
{
    public interface IUserService : IApiService<User>
    {
        Task<bool> Put(string clientId, User value);
    }
}
