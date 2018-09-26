using System.Threading.Tasks;

namespace Server.Service
{
    public interface IAccountService
    {
        Task<bool> RegistrateAsync(string token);
    }
}