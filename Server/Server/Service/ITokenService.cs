using Server.Service.Model;
using System.Threading.Tasks;

namespace Server.Service
{
    public interface ITokenService
    {
        Task<Token> GetTokenAsync();
    }
}
