using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Database.Model;

namespace Server.Service
{
    public interface IApiService<T> where T : IModel
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task<bool> Post(T value);
    }
}
