using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinClient.Models;

namespace XamarinClient.Controllers
{
    interface IController<T> where T : IModel
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string id);
        Task<bool> PostAsync(T value);
        Task<bool> PutAsync(string id, T value);

        event Action TokenChanged;
    }
}
