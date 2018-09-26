using Microsoft.AspNetCore.Mvc;
using Server.Database;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using System.Threading.Tasks;
using Server.Component;
using Server.Service;
using Server.Service.Model;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IDatabaseWorker<User> _databaseWorker;
        private readonly ITokenConverter<string> _tokenConverter;
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;

        public LoginController(Context context)
        {
            _databaseWorker = new UserDatabaseWorker(context);
            _tokenConverter = new TokenToUserIdConverter();
            _accountService = new AccountService(context);
            _tokenService = new TokenService();
        }

        [HttpPost]
        public async Task<Token> Post([FromBody] string token)
        {
            _tokenConverter.Content = token;
            string clientId = _tokenConverter.Convert();
            User user = await _databaseWorker.GetAsync(clientId);
            if (user == null)
            {
                bool result = await _accountService.RegistrateAsync(token);
                if (!result)
                    return null;
            }
            Token userToken = await _tokenService.GetTokenAsync();
            return userToken;
        }
    }
}