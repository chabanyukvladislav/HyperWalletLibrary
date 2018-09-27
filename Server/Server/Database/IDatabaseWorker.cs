using Server.Database.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Database
{
    public interface IDatabaseWorker<T> where T : IModel
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string clientUserId);
        Task<bool> PostAsync(T item);
        Task<bool> PutAsync(string clientUserId, T value);
    }
}