using System.Threading.Tasks;
using XamarinClient.Models;

namespace XamarinClient.OAuth
{
    interface ILoginController
    {
        Task<Token> LoginAsync();
    }
}
