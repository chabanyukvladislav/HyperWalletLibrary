using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Database.Model;

namespace Server.Api
{
    public interface IApiWorker<T> where T : IModel
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string token);
        Task<T> PostAsync(T item);
        Task<T> PutAsync(string token, T item);
    }
}
