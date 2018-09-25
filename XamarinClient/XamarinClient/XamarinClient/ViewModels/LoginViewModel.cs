using System.Windows.Input;
using Auth0.OidcClient;
using IdentityModel.OidcClient;
using Xamarin.Forms;
using XamarinClient.Controllers;

namespace XamarinClient.ViewModels
{
    class LoginViewModel
    {
        private const string DOMAIN = "itstep1511.eu.auth0.com";
        private const string CLIENT_ID = "OxESJUZoUQoc6zZLNMGNf4ZoCTsORBoM";

        private readonly IAuth0Client _client;
        private readonly AccountController _controller;

        public ICommand Login { get; }

        public LoginViewModel()
        {
            Login = new Command(ExecuteLogin);
            _controller = new AccountController();
            _client = new Auth0Client(new Auth0ClientOptions()
            {
                Domain = DOMAIN,
                ClientId = CLIENT_ID
            });
        }

        private async void ExecuteLogin()
        {
            LoginResult result = await _client.LoginAsync();
            if (!result.IsError)
            {
            }
        }
    }
}
