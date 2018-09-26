using System.Threading.Tasks;
using Server.Component;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUserService _service;
        private readonly ITokenConverter<User> _tokenConverter;

        public AccountService(Context context)
        {
            _service = new UserService(context);
            _tokenConverter = new TokenToUserConverter();
        }

        public async Task<bool> RegistrateAsync(string token)
        {
            _tokenConverter.Content = token;
            User user = _tokenConverter.Convert();
            user.AddressLine1 = "unknown";
            user.City = "unknown";
            user.PostalCode = "unknown";
            user.StateProvince = "unknown";
            user.Country = "ua";
            bool result = await _service.Post(user);
            return result;
        }
    }
}